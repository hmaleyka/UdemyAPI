﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTask.Business.DTOs.CategoryDtos
{
    public class CategoryCreateDto
    {
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
    }
}
