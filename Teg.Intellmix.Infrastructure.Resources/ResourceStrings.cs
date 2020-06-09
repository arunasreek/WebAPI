using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Resources.Models;

namespace Esmart.Infrastructure.Resources
{
    public static class ResourceStrings
    {             
        public static List<StaticDashboardDetails> GetStaticDashboardDetails
        {           
            get
            {
                List<StaticDashboardDetails> staticDashboardDetails = new List<StaticDashboardDetails>
                {
                    new StaticDashboardDetails { DashboardName = "Executive Dashboard", DashboardUrl = "t/CCPG/views/Executive-PostMMM/ExecutiveDashbaord"},
                    new StaticDashboardDetails { DashboardName = "Media Effectiveness", DashboardUrl = "t/CCPG/views/MediaEffectiveness-PostMMM/MediaEffectiveness" },
                    new StaticDashboardDetails { DashboardName = "Trend Analysis", DashboardUrl = "t/CCPG/views/TrendAnalysis-PostMMM/TrendAnalysis"},
                    new StaticDashboardDetails { DashboardName = "Volume Contribution", DashboardUrl = "t/CCPG/views/WaterfallAnalysis/VolumeDistribution"},
                    new StaticDashboardDetails { DashboardName = "Data Summary", DashboardUrl = "t/CCPG/views/DataSummary-PostMMM/DataSummary"}
                };
                return staticDashboardDetails;
            }
        }

        #region A
        public static string AtleastOnePrivilege { get { return "At least one Privilege required to create a Role!"; } }
        public static string ActionNull { get { return "Atleast select one action!"; } }
        public static string AtleastOneAdmin { get { return "At least one admin is required!"; } }
        #endregion

        #region B
        public static string BusinessUnitAlreadyPresent { get { return "Business Unit for the Organisation with same name already exists!"; } }        
        #endregion

        #region C
        public static string CycleQuarterly { get { return "4"; } }
        public static string CycleHalfYearly { get { return "2"; } }
        public static string CycleYearly { get { return "1"; } }
        public static string CannotChangeProcessType { get { return "Cannot change process type - File Upload!"; } }
        public static string ChangeDefaultPassword { get { return "Please change your password using the activation link sent to the email!"; } }
        #endregion

        #region D        
        public static string DashboardURLEmpty { get { return "Dashboard URL is empty!"; } }
        public static string DashboardDoesntBelongToTheOrganisation { get { return "Dashboard doesn't belong to the organisation!"; } }
            public static string DashboardNotAssignedToUser { get { return "Dashboard not assigned for this user!"; } }
            public static string DashboardNotFound { get { return "Dashboards not found!"; } }
			public static string DashboardAlreadyPresentForUser { get { return "Dashboard already exists for this user!"; } }
			public static string DefaultPassword { get { return "d3f@ult@PASS123"; } }
            public static string DuplicateEmail { get { return "Email already exists!"; } }
            public static string DuplicateFileProcessStateLog { get { return "File process state log already exists!"; } }
            public static string DuplicateColumnName { get { return "Duplicate column name!"; } }
            public static string DuplicateBusinessUnit { get { return "Duplicate business unit!"; } }
            public static string DuplicateDashboard { get { return "Duplicate dashboard!"; } }
            public static string DuplicateChannel { get { return "Duplicate channel!"; } }
            public static string DuplicateKPI { get { return "Duplicate KPI!"; } }
            public static string DuplicateRole { get { return "Duplicate role!"; } }
            public static string DuplicateUserColumMapping { get { return "Duplicate user column mapping!"; } }
            public static string DoesntBelongUploadedFileDetailsAndOrganisation { get { return "Invalid File Id!"; } }
            public static string DoesntBelongRevisionAndUploadedFileDetails { get { return "Invalid Revision Id!"; } }
            public static string DoesntBelongBusinessUnitAndOrganisation { get { return "Business unit doesn't belongs to the organisation!"; } }
            public static string DoesntBelongFileTypeAndOrganisation { get { return "File type doesn't belongs to the organisation!"; } }
            public static string DoesntBelongPeriodAndOrganisation { get { return "Invalid Period Id!"; } }
        #endregion


        #region E
        public static string ETLCSVNotFound { get { return "ETL CSV not found!"; } }
        public static string ErrorMessage { get { return "Oops, there was some error!"; } }
        public static string EmailSent { get { return "Email successfully sent!"; } }
        public static string EmailFailed { get { return "Problem while sending email!"; } }
        public static string EmailFormatRequired { get { return "Organisation email format is required!"; } }
        /// <summary>
        /// Email Id is invalid.
        /// </summary>
        public static string EmailValidCheck { get { return "Email Id is invalid."; } }
        public static string TokenValidaCheck { get { return "Token is invalid."; } }
        #endregion

        #region F
        public static string FileApprovalAlreadyDone { get { return "File approval already done!"; } }
        public static string FileAlreadyDiscarded { get { return "File already discarded!"; } }
        public static string FileTypeNotFound { get { return "File type not found!"; } }
        public static string FileTypeAlreadyPresent { get { return "File type with same name already exists!"; } }
        public static string FileExtensionNotAllowed { get { return "Only jpg, jpeg and png file are allowed!"; } }
        public static string FileTypeExtensionNotAllowed { get { return "Only csv, xlsx and xls file are allowed!"; } }
        public static string FirstNameEmpty { get { return "First name cannot be empty!"; } }
        public static string FileNotFound { get { return "File is required!"; } }
        public static string FileNotExists { get { return "File not found: {0} "; } }
        public static string FileUploadFailed { get { return "File upload failed : "; } }
        #endregion

        #region I            
        public static string InvalidProcessType { get { return "Invalid process type!"; } }
        public static string InvalidPhoneNumber { get { return "Invalid phone number!"; } }
        public static string InvalidPhoneNumberLength { get { return "Invalid phone number length!"; } }
        public static string IncorrectEmail { get { return "Incorrect email!"; } }
        public static string IncorrectKPI { get { return "Please select 4 KPI's"; } }
        public static string InternalServerError { get { return "Internal server error!"; } }
        public static string InvalidOrganisationName { get { return "Please provide a valid organisation name!"; } }
        public static string InvalidOrganisationEmailFormat { get { return "Please provide a valid Email Format!"; } }
        public static string InvalidBUName { get { return "Please provide a valid Business unit name!"; } }
        public static string InvalidSubscriptionId { get { return "Invalid Subscription Id!"; } }
        public static string InvalidCycleId { get { return "Invalid cycle Id!"; } }
        public static string InvalidPeriodId { get { return "Invalid period Id!"; } }
        public static string InvalidFileId { get { return "Invalid file Id!"; } }
        public static string InvalidETLFileGroupId { get { return "Invalid ETL file group Id!"; } }
        public static string InvalidBusinessUnitId { get { return "Invalid business unit Id!"; } }
        public static string InvalidFileLogId { get { return "Invalid file log Id!"; } }
        public static string InvalidUploadedFileDetailsId { get { return "Invalid uploaded file details Id!"; } }
        public static string InvalidUploadedFileRevisionId { get { return "Invalid uploaded file revision Id!"; } }
        public static string InvalidOrganisationId { get { return "Invalid organisation Id!"; } }
        public static string InvalidStatus { get { return "Invalid Status Id!"; } }
        public static string InvalidFirstName { get { return "Invalid first name!"; } }
        public static string InvalidLastName { get { return "Invalid last name!"; } }
        public static string InvalidPasswordLength { get { return "Password should be at least 8 characters long!"; } }
        public static string InvalidFileName { get { return "Invalid file type name!"; } }
        public static string InvalidColumnName { get { return "Invalid column name!"; } }
        public static string InvalidColumnType { get { return "Invalid column name!"; } }
        public static string InvalidColumnNullable { get { return "Nullable cannot be empty!"; } }
        public static string InvalidLogoURL { get { return "Invalid Logo URL!"; } }
        public static string InvalidEmailType { get { return "Invalid email type!"; } }
        public static string InvalidMissingValuesActionType { get { return "Invalid missing values action type!"; } }
        public static string InvalidMissingValuesActionAndColumnType { get { return "Invalid missing values action & column type!"; } }
        public static string InvalidDuplicateValuesActionType { get { return "Invalid duplicate Values action type!"; } }
        public static string InvalidPassword { get { return "Please choose a different password!"; } }
        public static string InvalidProcessState { get { return "Invalid process state!"; } }
        public static string InvalidPasswordFormat { get { return " The password should be a combination of upper case, lower case letters, digits and special characters"; } }
        public static string InvalidFileState { get { return "Invalid file state!"; } }
        #endregion


        #region K
        public static string KPINotFound { get { return "KPI's not found!"; } }
        public static string KPIAlreadyPresentForUser { get { return "KPI already exists for this user!"; } }
        #endregion

        #region L
        public static string LogoNotFound { get { return "Organisation logo is required!"; } }
        public static string LastNameEmpty { get { return "Last name cannot be empty!"; } }
        #endregion

        #region M
        public static string MediaChannelPresentForUser { get { return "Media channel already exists for this user!"; } }
        public static string MediaChannelNotFound { get { return "Media channels not found!"; } }
        public static string MethodResultDuplicate { get { return "Duplicate entry, this item already exists!"; } }
        public static string MethodResultItemsNotFound { get { return "No items found!"; } }
        public static string ModelNotValid { get { return "Model not valid!"; } }
        public static string MethodNotAllowed { get { return "Method not allowed!"; } }
        public static string LimitExceeded { get { return "Limit Exceeded!"; } }
        public static string MissingValueError
        {
            get
            {
                return "The file has too many issues.Please fix the issues and reupload the file.You can find a detailed list of issues in your email. ";
            }
        }
        public static string MissingValueString { get { return "string"; } }
        public static string MissingValueAlphanumeric { get { return "alphanumeric"; } }
        #endregion

        #region N
        public static string NewUserActivationLink { get { return "http://49.204.81.188/"; } }
        public static string NoBusinessUnitAdded { get { return "Business unit can't be empty!"; } }
        public static string NotFound { get { return "Resource not found!"; } }
        public static string NoBusinessFileTypeColumnsAdded { get { return "File type columns can't be empty!"; } }
        public static string NoFileProcessingStateFound { get { return "File processing state not found!"; } }
        public static string NoEngineColumMappingFound { get { return "Engine colum mapping not found!"; } }
        public static string NoRecordsFound { get { return "No records found!"; } }
        public static string NoLogsFound { get { return "No logs found!"; } }
        #endregion

        #region O
        public static string OrganisationNotFound { get { return "Organisation doesnt exists!"; } }
        public static string OrganisationAlreadyPresent { get { return "Organisation with same name already exists!"; } }
        public static string OnlyOneFileCanBeSelfApproved { get { return "Only one file can be self approved at a time!"; } }
        public static string OnlyOneFileCanBeApproved { get { return "Only one file can be approved at a time!"; } }
        public static string OwnerNotAssigned { get { return "Owner not assigned!"; } }


        #endregion

        #region P
        public static string PrevilegeNotFound { get { return "Previlege not found!"; } }
        public static string PeriodString { get { return "Adwords"; } }
        public static string PeriodDate { get { return "25/11/2019"; } }
        public static string PeriodDatetime { get { return "25/11/2019 "; } }
        public static string PeriodInt { get { return "123456"; } }
        public static string PeriodDecimal { get { return "17.578"; } }
        public static string PeriodUndefined { get { return "Undefined"; } }
        public static string PasswordsDoNotMatch { get { return "New Password and Confirm Password do not match!"; } }

        #endregion

        #region R
        public static string RoleAlreadyPresent { get { return "Role with same name already exists!"; } }
        public static string RoleIsEmpty { get { return "Role can not be Empty or Null!"; } }
        public static string RoleHasSpecialCharacter { get { return "No Special Character or Space!"; } }
        public static string RoleNotFound { get { return "Role not found!"; } }
        public static string RoleNotAssigned { get { return "Role not assigned to this user!"; } }
        public static string RoleAtleastOne { get { return "Assign atleast one role to this user!"; } }
        public static string RemarksMandatory { get { return "Remarks is mandatory!"; } }
        #endregion

        #region R
        public static string SampleBoolean { get { return "True"; } }
        public static string SampleChar { get { return "A"; } }
        public static string SampleFloat { get { return "725929.16"; } }
        public static string SampleAlphanumeric { get { return "0511APP"; } }
        #endregion

        #region T
        public static string TEGEmailFormat { get { return "@teganalytics.com"; } }
        public static string TokenExpired { get { return "Access token has expired!"; } }
        #endregion

        #region U
        public static string UnableToPublishUser { get { return "Unable to publish user!"; } }
        public static string Unauthorized { get { return "Unauthorized!"; } }
        public static string UserNotFound { get { return "User doesn't belongs to the organisation!"; } }
        public static string UserActive { get { return "User is already active!"; } }
        public static string UploadedFileDetailsNotFound { get { return "Uploaded file details not found!"; } }
        public static string UnableToGeneratePDF { get { return "Unable to generate PDF!"; } }
        public static string UserColumMappingEmpty { get { return "User colum mapping cannot be empty!"; } }
        #endregion

        #region Tableau Server Details
        public static string TableauServerUrl { get { return "https://bit.analytics-hub.com/"; } }
        public static string TableauUserName { get { return "admin"; } }
        public static string SiteName { get { return "CCPG"; } }
        public static string TableauContentType { get { return "application/x-www-form-urlencoded"; } }
        public static string TableauExceptionValue { get { return "-1"; } }
        public static string DashboardAuthenticationFailed { get { return "Dashboard authentication failed!"; } }
        #endregion
            }
}
