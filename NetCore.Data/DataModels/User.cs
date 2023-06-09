﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Data.DataModels
{
    public class User
    {
        [Key, StringLength(50), Column(TypeName = "varchar(50)")]
        public string UserId { get; set; }

        [Required, StringLength(100), Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; }

        [Required, StringLength(320), Column(TypeName ="varchar(320)")]
        public string UserEmail { get; set; }

        [Required, StringLength(130), Column(TypeName = "nvarchar(130)")]
        public string Password { get; set; }

        [Required]
        public bool IsMemberShipWithDrawn { get; set; } // 회원탈퇴여부

        public DateTime JoinedUtcDate { get; set; }
    }
}
