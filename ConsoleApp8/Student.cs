﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//     Creater: dylan
//     Date:    2018/3/14 17:51
//     Version: 2.0.0.0
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Chloe.Entity;

namespace ConsoleApp8
{
    /// <summary>
    /// student info
    /// </summary>
    [TableAttribute("Student",ConfigName = "SqlSugar4XTest")]
    public class Student
    {
        /// <summary>
        /// Pk.
        /// </summary>
        [ColumnAttribute(Name = "Id", IsPrimaryKey = true)]
        public int? Id { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public int? SchoolId { get; set; }

        /// <summary>
        /// Student Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// .
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}


