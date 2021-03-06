using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreApp.Data 
{
    public class OperationType
    {
	    [Key]
        public int OperationTypeId{ get; set;}
	    [Required]
        public string DisplayValue{ get; set;} 
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }      
        public string UpdatedBy { get; set; }
        public ICollection<Operation> Operations { get; set; }
    }
}
