using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Infrastructure.Resources
{
    public class PushNotificationTemplate
    {
        public static string OrganisationCreate
        {
            get
            {
                return "{0} created";
            }
        }

        public static string OrganisationEdit
        {
            get
            {
                return "{0} edited ";
            }
        }

        /// <summary>
        /// org Name
        /// </summary>
        public static string NewDataSource
        {
            get
            {
                return "New Data source for {0}";
            }
        }

        /// <summary>
        /// BU name
        /// </summary>
        public static string NewBU
        {
            get
            {
                return "New BU {0} Adedd ";
            }
        }

        /// <summary>
        /// BU name
        /// </summary>
        public static string NewAdmin
        {
            get
            {
                return "Admin added for {0}";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string NewUser
        {
            get
            {
                return "New User Created ";
            }
        }

        /// <summary>
        /// Org Name
        /// </summary>
        public static string EditUserRole
        {
            get
            {
                return " User Edited for {0}";
            }
        }

        /// <summary>
        /// Org Name
        /// </summary>
        public static string NewRole
        {
            get
            {
                return "New Role Added";
            }
        }

        /// <summary>
        ///  BU name,File Name,Step name
        /// </summary>
        public static string ChangeOwner
        {
            get
            {
                return "Owner for {0} {1} {2} Updated ";
            }
        }


        /// <summary>
        ///  BU name,File Name,Step name
        /// </summary>
        public static string ChangeDueDate
        {
            get
            {
                return "Due date for {0} {1} {2} Updated ";
            }
        }

        /// <summary>
        ///  BU name,File Name,Step name
        /// </summary>
        public static string ProcessTypeChange
        {
            get
            {
                return "{0} {1} {2} Updated ";
            }
        }

    }
}
