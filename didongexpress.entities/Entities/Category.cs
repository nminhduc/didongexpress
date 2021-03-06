﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace didongexpress.entities
{
    /// <summary>
    /// treat as sub category
    /// </summary>
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        

        /// <summary>
        /// sony-xperia-xa-16gb-dual-white ==> this is called slug (name of product for seo)
        /// </summary>
        public string Slug { get; set; }

        /// <summary>
        /// higher is first
        /// </summary>
        public int Order { get; set; }        

        public ICollection<Product> Products { get; set; } // that mean, 1 category has many products

        /// <summary>
        /// if parent id == null ==> this is a category
        /// otherwise, this is a sub-category, and parent is parent id
        /// </summary>
        [ForeignKey("ParentCategory")]
        public int? ParentId { get; set; }
        public Category ParentCategory { get; set; }
    }
}
