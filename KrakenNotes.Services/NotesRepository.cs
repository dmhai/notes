﻿using KrakenNotes.Data;
using KrakenNotes.Data.Models;
using KrakenNotes.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KrakenNotes.Services
{
    public class NotesRepository : Repository<Note>, INotesRepository
    {
        public NotesRepository(KrakenNotesContext context) : base(context)
        {
            
        }

        public IEnumerable<Note> GetNotesByUserId(int id)
        {
            return GetAll().Where(e => e.UserId == id).ToList();
        }
    }
}
