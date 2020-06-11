using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teg.Intellmix.Application.Models;
using Teg.Intellmix.Application.ServiceContract;
using Teg.Intellmix.Infrastructure.Models;
using Teg.Intellmix.Infrastructure.UOWContract;

namespace Teg.Intellmix.Application.Services
{
    public class SubscriptionService : ServiceBase, ISubscriptionService
    {
        private IUnitOfWork _unitOfWork;

        public SubscriptionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }        

        public async Task<IEnumerable<Subscription>> GetAllSubscriptions()
        {
            var mytask = Task.Run(async () =>
            {
                var source = (await _unitOfWork._subscriptionRepository.GetAllSubscriptions()).ToList();
                //return AutoMapper.Mapper.Map<List<Teg.Intellmix.Infrastructure.Models.Subscription>, List<Subscription>>(source);
                List<Subscription> lst = new List<Subscription>();
                lst.Add(new Subscription()
                {
                    Id = source.First().Id,
                    Period = source.First().Period
                });
                return lst;
            });

            return await mytask;
           
        }
    }
}
