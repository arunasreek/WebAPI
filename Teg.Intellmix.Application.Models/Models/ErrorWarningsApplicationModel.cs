
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Application.Models.Models
{
    public class ErrorWarnings
    {
        public ErrorWarningsApplicationModel ErrorWarningsDetails { get; set; }
    }

    public class ErrorWarningsApplicationModel
    {
        public string FileTypeName { get; set; }
        public bool HasThresholdExceeded { get; set; }
        public bool IsMissingValueNullableError { get; set; }
        public string MissingValueNullableErrorMessage { get; set; }
        public DataTypeValidation DataTypeValidation { get; set; }        
        public MissingValue MissingValue { get; set; }
        public Outlier Outlier { get; set; }
        public DuplicateValue DuplicateValue { get; set; }
    }

    public class DataTypeValidation
    {
        public string DataTypeValidationName { get; set; }
        public string DataTypeValidationCautionType { get; set; }
        public int DataTypeValidationCautionCount { get; set; }
        public List<DataTypeValidationLogApplicationModel> DataTypeValidationLog { get; set; }
    }

    public class Outlier
    {
        public string OutlierValidationName { get; set; }
        public string OutlierValidationCautionType { get; set; }
        public int OutlierValidationCautionCount { get; set; }
        public List<OutlierLogApplicationModel> OutlierLog { get; set; }
    }

    public class OutlierLogApplicationModel
    {
        public int Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public int DataCheckMasterId { get; set; }
        public string DataCheckType { get; set; }
        public int CautionTypeId { get; set; }
        public string CautionType { get; set; }        
        public string ColumnName { get; set; }
        public int RowNo { get; set; }
        public decimal ColumnValue { get; set; }
        public decimal MinRange { get; set; }
        public decimal MaxRange { get; set; }      
    }

    public class MissingValue
    {
        public string MissingValueValidationName { get; set; }
        public string MissingValueValidationCautionType { get; set; }
        public int MissingValueValidationCautionCount { get; set; }
        public List<MissingValueLogApplicationModel> MissingValueLog { get; set; }
    }

    public class MissingValueLogApplicationModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public int DataCheckMasterId { get; set; }
        public string DataCheckType { get; set; }
        public int CautionTypeId { get; set; }
        public string CautionType { get; set; }
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public int NoOfMissingValues { get; set; }
        public bool IsNullable { get; set; }        
        public object MissingValueAction { get; set; }
    }

    public class MissingValueActionNumeric
    {
        public int Zero { get; set; }
        public string Mean { get; set; }
        public string Median { get; set; }
        public string Mode { get; set; }
    }

    public class MissingValueActionString
    {
        public string Unknown { get; set; }        
    }

    public class DuplicateValue
    {
        public string DuplicateValueValidationName { get; set; }
        public string DuplicateValueValidationCautionType { get; set; }
        public int DuplicateValueValidationCautionCount { get; set; }
        public int DuplicateValueRowSetsCount { get; set; }
        public List<KeyValuePair<string, string>> DuplicateValueLogRowSets { get; set; }
        public List<DuplicateValueLogApplicationModelSet> DuplicateValueLogSets { get; set; }
    }

    public class DuplicateValueLogApplicationModelSet
    {
        public string DuplicateRowNo { get; set; }
        public DataTable DuplicateData { get; set; }
    }

    public class ErrorWarningsDetailsApplicationModel
    {
        public Validation Validations { get; set; }
    }

    public class Validation
    { 
        public List<DataTypeValidationLogApplicationModel> DataTypeValidationLog { get; set; }
        public List<DuplicateValueLogApplicationModel> DuplicateValueLog { get; set; }
        public List<MissingValuesLogApplicationModel> MissingValuesLog { get; set; }
    }

    public class DuplicateValueLogApplicationModel
    {
        public Guid SetId { get; set; }
        public int UpdateMode { get; set; }       
    }

    public class MissingValuesLogApplicationModel
    {
        public Guid Id { get; set; }
        public int UploadedFileDetailsId { get; set; }
        public int UploadedFileRevisionNo { get; set; }
        public string ColumnName { get; set; }       
        public int ActionType { get; set; }
        public string ColumnType { get; set; }
    }
}
