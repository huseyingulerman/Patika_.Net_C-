﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_todo_uygulamasi
{
    public class Card
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Type Type { get; set; }
        public CardSize Size { get; set; }
        public TeamMember Member { get; set; }

        public Card(string title, string content, Type type, CardSize size, TeamMember member)
        {
            this.Member = member;
            this.Title = title;
            this.Content = content;
            this.Type = type;
            this.Size = size;
        }
    }
}
