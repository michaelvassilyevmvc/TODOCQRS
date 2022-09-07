﻿using Domain.Common;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TodoList: AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Colour Colour { get; set; } = Colour.White;
        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
