﻿using inheritenceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritenceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }

        public static void runApp()
        {
            SubjectTeacher algebra = new SubjectTeacher();
            algebra.Name = "Algebra";

            SubjectTeacher physics = new SubjectTeacher();
            physics.Name = "Physics";

            SubjectTeacher algebraTeacher = new SubjectTeacher();
            algebraTeacher.Name = "Mr.Algebra";
            algebraTeacher.ContactAddress = "Some Address";
            algebraTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            algebraTeacher.WhichSubject = algebra;

            SubjectTeacher physicsTeacher = new SubjectTeacher();
            physicsTeacher.Name = "Mr.Physics";
            physicsTeacher.ContactAddress = "Some Address";
            physicsTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            physicsTeacher.WhichSubject = physics;

            CClass class8 = new CClass();
            class8.Name = "8";

            ClassTeacher teacherOf8 = new ClassTeacher();
            teacherOf8.Name = "Mrs.Class 8 Teachers";
            teacherOf8.ContactAddress = "Some Address";
            teacherOf8.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            teacherOf8.WhichClass = class8;

            class8.WhichTeacher = teacherOf8;



        }

    }
}

