﻿namespace ZyferaCase.Data
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; } 
        public string Code { get; set; }
        public int Value { get; set; }
    }
}
