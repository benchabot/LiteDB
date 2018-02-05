﻿using System;
using System.Collections.Generic;
using System.IO;

namespace LiteDB
{
    /// <summary>
    /// Represent a simple structure to store added/removed pages in a transaction. One instance per transaction
    /// </summary>
    internal class TransactionPages
    {
        /// <summary>
        /// Get how many pages are involved in this current transaction across all snapshots
        /// </summary>
        public int PageCount { get; set; } = 0;

        /// <summary>
        /// Handle created pages during transaction (for rollback) - Is a list because order is important
        /// </summary>
        public List<uint> NewPages { get; private set; } = new List<uint>();

        /// <summary>
        /// First deleted page 
        /// </summary>
        public BasePage FirstDeletedPage { get; set; }

        /// <summary>
        /// Last deleted page
        /// </summary>
        public BasePage LastDeletedPage { get; set; }

        /// <summary>
        /// Get deleted page count
        /// </summary>
        public int DeletedPages { get; set; }

    }
}