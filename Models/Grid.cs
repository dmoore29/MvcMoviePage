﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Grid
    {
        [Key]
        public int key { set; get; }
        public LocationGroup grid { set; get;}
        public int cId { set; get; }
        public int action { set; get; }


        //public Grid()
        //{

        //}

        //public Location[,] getGrid()
        //{
        //    return grid;
        //}

        //public int getId(int i, int j)
        //{
        //    return grid[i,j].getId();
        //}

        //public void update(int i, int j, int id)
        //{
        //    grid[i, j].setId(id);
        //}

        //public void setAction(int set)
        //{
        //    action = set;
        //}

        //public int getAction()
        //{
        //    return action;
        //}
    }
}
