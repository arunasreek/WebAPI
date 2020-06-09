using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teg.Intellmix.Infrastructure.Data;
using Teg.Intellmix.Infrastructure.Models.Models;
using Teg.Intellmix.Infrastructure.RepositoryContract.Interfaces;

namespace Teg.Intellmix.Infrastructure.Repository.Classes
{
   public class OrganisationUserPrevilegeRepository : Repository<Org_UserPrivilege>, IOrganisationUserPrevilegeRepository
    {
        public OrganisationUserPrevilegeRepository(IntellmixEntities context) : base(context)
        {

        }

        public async Task<List<UserAccessInfrastructureModel>> GetAccessPermissionDetailsAsync(int organisationId, int businessUnitId, string UserId)
        {
            var GetAccessPermissionDetailsTask = Task.Run(async () =>
            {

                using (var context = new IntellmixEntities())
                {
                    return context.Org_UserPrivilege
                                  .Where(x => x.IsActive == true && x.UserId == UserId && x.BusinessUnitId == businessUnitId && x.OrganisationId == organisationId)
                                  .Select(x => new UserAccessInfrastructureModel()
                                  {
                                      FileId = x.FileId,
                                      PrevilegeId = x.PrivilegeId,
                                      ProcessState = x.ProcessStateId,
                                      Id=x.Id

                                  }).ToList();

                }

            });

            return await GetAccessPermissionDetailsTask;
        }

        public async Task<ApprovalInfrastructureModel> GetPendingApprovalsAsync(int organisationId, int businessUnitId, string UserId, long Id, int ProcessState)
        {
            throw new NotImplementedException();

            //var GetPendingApprovalsTask = Task.Run(async ()=> {

            //    using (var context = new IntellmixEntities())
            //    {
            //        return context.Org_UserPrivilege
            //                      .Join(context.UploadedFileDetails,
            //                            up=>up.FileId,
            //                            ufd=>ufd.OrgFileId,
            //                            (up,ufd)=> new { UP=up,UFD=ufd })
            //                      .Join(context.AspNetUsers,
            //                            upufd=>upufd.UFD.CreatedBy,
            //                            anu=>anu.Id,
            //                            (upufd,anu)=> new { UP_UFD= upufd, ANU=anu })
            //                      .Join(context.Org_FileByOrg,
            //                            result => result.UP_UFD.UP.FileId,
            //                            ofbo=> ofbo.Id,
            //                            (result,ofbo)=> new {Result= result,OFBO= ofbo })
            //                      .Join(context.Org_BU,
                                        
            //                            )
            //                      .GroupJoin(context.FileProcessStateLogs,
            //                            result=> result.Result.UP_UFD.UFD.Id,
            //                            fpsl=>fpsl.UploadedFileDetailsId,
            //                            (result,fpsl)=> new { Combination= result, FPSL=fpsl})
            //                      .SelectMany(
            //                        x=> x.FPSL.DefaultIfEmpty(),
            //                        (x,y)=> new { LEFT=x, RIGHT=y})
            //                      .Where(z=> z.LEFT.Combination.Result.UP_UFD.UP.Id==Id && z.RIGHT.ProcessState== ProcessState)
            //                      .Select(x=> new ApprovalInfrastructureModel()
            //                      {
                                        

            //                      }).FirstOrDefault()
            //    }

            //})
        }
    }
}
