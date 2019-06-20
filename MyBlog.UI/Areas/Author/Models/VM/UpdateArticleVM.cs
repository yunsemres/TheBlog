﻿using MyBlog.DAL.ORM.Entity;
using MyBlog.UI.Areas.Author.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.UI.Areas.Author.Models.VM
{
    public class UpdateArticleVM
    {
        public UpdateArticleVM()
        {
            Categories = new List<Category>();
            Article = new ArticleDTO();
        }
        public List<Category> Categories { get; set; }
        public ArticleDTO Article { get; set; }
    }
}