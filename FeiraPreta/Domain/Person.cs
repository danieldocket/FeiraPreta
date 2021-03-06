﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FeiraPreta.Domain
{
    public class Person
    {
        public Guid Id { get; set; }

        public string UsernameInstagram { get; set; }

        public string FullNameInstagram { get; set; }

        public Byte[] ProfilePictureInstagram { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        #region Navigation

        public ICollection<Publication> Publications { get; set; }

        #endregion
    }
}
