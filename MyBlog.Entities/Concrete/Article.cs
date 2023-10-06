﻿using MyBlog.Shared.Entities;

namespace MyBlog.Entities.Concrete
{
    public class Article : EntityBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }    // Küçük resim
        public DateTime Date { get; set; }
        public int ViewCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
