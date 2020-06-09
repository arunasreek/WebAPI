using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Infrastructure.Resources
{
    public class EmailTemplate
    {
        public static string EngineColumMappingSubject
        {
            get
            {
                return "File Ready for Mapping.";
            }
        }
        public static string EngineColumMappingBody
        {
            get
            {
                return "Hi strUserName,<br><br>" +
                       "The data is uploaded. Please map the columns to continue with harmonization process.<br><br>" +
                       "Regards,<br>" +
                       "Team IntellMix";
            }
        }
        public static string UserColumMappingSubject
        {
            get
            {
                return "Data mapping is done.";
            }
        }
        public static string UserColumMappingBody
        {
            get
            {
                return "Hi strUserName,<br><br>" +
                       "Colum mapped. The harmonization process has started.<br><br>" +
                       "strColumnDetails <br>" +
                       "Regards,<br>" +
                       "Team IntellMix";
            }
        }
        public static string ErrorsWarningsSubject
        {
            get
            {
                return "The file for data type strFileName processed, strErrorCount Errors & strWaringCount Warings detected.";
            }
        }
        public static string ErrorsWarningsBody
        {
            get
            {
                return "Hi strUserName,<br><br>" +
                       "The file for data type strFileName was processed & strErrorCount Errors & strWaringCount Warings were detected.<br><br>" +
                       " <table style = 'border-collapse: collapse';> " +
                       "<tr style = 'border: 1px solid #dddddd;text-align: left;padding: 8px;'>" +
                       "<td style = 'border: 1px solid #dddddd;text-align: left;padding: 8px;' > Errors </td>" +
                       "<td style = 'border: 1px solid #dddddd;text-align: left;padding: 8px;' > strErrorCount </td>" +
                       "</tr>" +
                       "<tr style = 'border: 1px solid #dddddd;text-align: left;padding: 8px;'>" +
                       "<td style = 'border: 1px solid #dddddd;text-align: left;padding: 8px;' > Warings </td>" +
                       "<td style = 'border: 1px solid #dddddd;text-align: left;padding: 8px;' > strWaringCount </td>" +
                       "</tr>" +
                       "</table><br>" +
                       "Please find the detailed data quality report attached.<br>" +
                       "If you are satisfied with the file quality please submit the file from portal.<br><br>" +
                       "Regards,<br>" +
                       "Team IntellMix";
            }
        }

        public static string SendNotificationSubject
        {
            get
            {
                return "{0} Has sent you a message.";
            }
        }

        public static string FileUploadSubject
        {
            get
            {
                return "{0} for {1} Has been submitted ";
            }
        }

        public static string FileUploadBody
        {
            get
            {
                return "{0} for {1} has Been Submitted for Approval" +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string FileApprovalSubject
        {
            get
            {
                return "{0} for {1} Has been Approved ";
            }
        }

        public static string FileApprovalBody
        {
            get
            {
                return "{0} for {1} has Been Submitted for Approval" +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string FileApprovalRejectSubject
        {
            get
            {
                return "{0} for {1} Has been Rejected ";
            }
        }

        public static string FileApprovalRejectUploderBody
        {
            get
            {
                return "{0} for {1} has Been Rejected becasue {2}. Please upload a new file." +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string FileApprovalRejectOwnerBody
        {
            get
            {
                return "{0} for {1} has Been Rejected becasue {2}" +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string DataPreparationRejectSubject
        {
            get
            {
                return "Data for {0} Has been Rejected ";
            }
        }

        public static string DataPreparationRejectOwnerBody
        {
            get
            {
                return "{0} for {1} has Been Rejected becasue {2}." +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string DataPreparationRejectApproverBody
        {
            get
            {
                return "{0} for {1} has Been Rejected becasue {2}. Please reupload /re- approve." +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string DataPreparationApproveSubject
        {
            get
            {
                return "Data for {0} has been submitted and is ready to publish";
            }
        }

        public static string DataPreparationApproveOwnerBody
        {
            get
            {
                return "Data for {0} has been submitted. " +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string DataPreparationReportOwnerBody
        {
            get
            {
                return "Data for {0} is ready for publishing." +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string ReportApproveSubjectAndBody
        {
            get
            {
                return "Data for {0} has been published " +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        /// <summary>
        /// Bu Name
        /// </summary>
        public static string ReportRejectSubject
        {
            get
            {
                return "Data for {0} has been Rejected";
            }
        }

        /// <summary>
        /// Org Name
        /// </summary>
        public static string OrgCreationSubject
        {
            get
            {
                return "{0} created";
            }
        }

        /// <summary>
        /// Org Name , subcription period, org cycle
        /// </summary>
        public static string OrgCreationBody
        {
            get
            {
                return "{0} was created for the subcription period of {1} and org cycle {2}" +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        /// <summary>
        /// BU Name and Remark
        /// </summary>
        public static string ReportRejectOwnerBody
        {
            get
            {
                return "{0} {1} has Been Rejected becasue {2}. Please fisx the issues." +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string SendNotificationBodyFileUploadAndApproval
        {
            get
            {
                //{0} UserName
                //{1} SenderName
                //{2} OrgName
                //{3} FileTypeName
                //{4} ProcessStates
                //{5} NotificationRemarks

                return "Hi {0}, <br><br>" +
                      "{1} has sent you a message from IntellMix regarding {2} {3} for {4} step.<br><br>" +
                      "{5} <br><br>" +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        public static string SendNotificationBodyDataPreperationAndReports
        {
            get
            {
                //return "Hi arun, <br><br>" +
                //       "ujj has sent you a message from IntellMix regarding strOrgName strFileTypeName for strProcessStates step.<br><br>" +
                //       "strNotificationRemarks <br><br>" +
                //       "Regards,<br><br>" +
                //       "ujj";

                //{0} UserName
                //{1} SenderName
                //{2} OrgName              
                //{3} ProcessStates
                //{4} NotificationRemarks

                return "Hi {0}, <br><br>" +
                      "{1} has sent you a message from IntellMix regarding {2} for {3} step.<br><br>" +
                      "{4} <br><br>" +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }


        public static string OrgEditSubject
        {
            get
            {
                return "{0} edited ";
            }
        }

        /// <summary>
        /// Org Name , subcription period, org cycle
        /// </summary>
        public static string OrgEditBody
        {
            get
            {
                return "{0} was updated to {1}" +
                      "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        /// <summary>
        /// org Name
        /// </summary>
        public static string NewDataSourceSubject
        {
            get
            {
                return "New Data source for {0}";
            }
        }

        /// <summary>
        /// Data Source Name,Org Name,Data Structure - Column name , type , Meta data and error threshold
        /// </summary>
        public static string NewDataSourceBody
        {
            get
            {
                return " New Data Source {0} was added to {1} with the folwing details {2}" + "<br>" +
                        "Regards,<br>" +
                      "Team IntellMix";
            }
        }

        /// <summary>
        /// File Name
        /// </summary>
        public static string ErrorTresholdSubject
        {
            get
            {
                return "Error Treshold Chnaged for {0}";
            }
        }

        /// <summary>
        /// File Name,Org Name,New Value
        /// </summary>
        public static string ErrorTresholdBody
        {
            get
            {
                return "Error Treshold Chnaged for {0} , {1} to {2}" + "<br>" +
                        "Regards,<br>" +
                      "Team IntellMix";
            }
        }



        /// <summary>
        /// File Name
        /// </summary>
        public static string NewBUSubject
        {
            get
            {
                return "New BU {0} Adedd ";
            }
        }

        /// <summary>
        /// BU Name,Org Name
        /// </summary>
        public static string NewBUBody
        {
            get
            {
                return "New BU {0} Adedd to the {1}" + "<br>" +
                        "Regards,<br>" +
                       "Team IntellMix";
            }
        }

        /// <summary>
        /// Org Name
        /// </summary>
        public static string NewAdminSubject
        {
            get
            {
                return "Admin added for {0}";
            }
        }

        /// <summary>
        /// User name,Org Name
        /// </summary>
        public static string NewAdminBody
        {
            get
            {
                return "{0}  was  added as an Admin  for {1}" + "<br>" +
                        "Regards,<br>" +
                       "Team IntellMix";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public static string NewUserSubject
        {
            get
            {
                return "New User Created ";
            }
        }

        /// <summary>
        /// User Name,BU Name
        /// </summary>
        public static string NewUserBody
        {
            get
            {
                return "New user created, {0} Was added to {1}" + "<br>" +
                        "Regards,<br>" +
                       "Team IntellMix";
            }
        }

        /// <summary>
        /// Org Name
        /// </summary>
        public static string EditUserRoleSubject
        {
            get
            {
                return " User Edited for {0}";
            }
        }

        /// <summary>
        /// User Name,Role name 
        /// </summary>
        public static string EditUserRoleBody
        {
            get
            {
                return "{0} was Edited, New Role {1} was adeed / Removed " + "<br>" +
                        "Regards,<br>" +
                       "Team IntellMix";
            }
        }

        /// <summary>
        /// Org Name
        /// </summary>
        public static string NewRoleSubject
        {
            get
            {
                return "New Role Added";
            }
        }

        /// <summary>
        /// User Name,Role name 
        /// </summary>
        public static string NewRoleBody
        {
            get
            {
                return "New Role {0} Added , with following permission {1}" + "<br>" +
                        "Regards,<br>" +
                       "Team IntellMix";
            }
        }


        /// <summary>
        /// BU name,File Name,Step name
        /// </summary>
        public static string ChangeOwnerSubject
        {
            get
            {
                return "Owner for {0} {1} {2} Updated ";
            }
        }

        /// <summary>
        /// UBU name,File Name,Step name,Old owner,New Owner
        /// </summary>
        public static string ChangeOwnerBody
        {
            get
            {
                return "The owner of {0} {1} {2} Updated from {3} to {4}" + "<br>" +
                        "Regards,<br>" +
                       "Team IntellMix";
            }
        }

        /// <summary>
        /// BU name,File Name,Step name
        /// </summary>
        public static string ChangeDueDateSubject
        {
            get
            {
                return "Due date for {0} {1} {2} Updated ";
            }
        }

        /// <summary>
        /// UBU name,File Name,Step name,Old date,New date
        /// </summary>
        public static string ChangeDueDateBody
        {
            get
            {
                return "The Due date of {0} {1} {2} Updated from {3} to {4}" + "<br>" +
                        "Regards,<br>" +
                       "Team IntellMix";
            }
        }

        /// <summary>
        /// BU name,File Name,Step name
        /// </summary>
        public static string ProcessTypeSubject
        {
            get
            {
                return "{0} {1} {2} Updated";
            }
        }

        /// <summary>
        /// UBU name,File Name,Step name
        /// </summary>
        public static string ProcessTypeBody
        {
            get
            {
                return "{0} {1} {1} has been changed to automatic / manual " + "<br>" +
                        "Regards,<br>" +
                       "Team IntellMix";
            }
        }

        /// <summary>
        /// BU name
        /// </summary>
        public static string FileSubmissionReadySubject
        {
            get
            {
                return "Files for {0} Ready for processing";
            }
        }

        /// <summary>
        /// BU name
        /// </summary>
        public static string FileSubmissionReadyBody
        {
            get
            {
                return "All the files are for {0} are ready for Data preparation";
            }
        }

    }
}
