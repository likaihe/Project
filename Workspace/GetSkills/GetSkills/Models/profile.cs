//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GetSkills.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class profile
    {
        public int profile_id { get; set; }

        [StringLength(100)]
        public string pic { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Member name is Required")]
        public string name { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(1000)]
        public string detail { get; set; }

        [StringLength(100)]
        public string linked_url { get; set; }

        public int status { get; set; }
    }
}
