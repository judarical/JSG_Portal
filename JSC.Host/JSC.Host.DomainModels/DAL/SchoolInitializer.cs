/*
* Created by: Yevgeniy A. Matveichev
* Created: 15/12/2015
* Copyright © Yevgeniy A. Matveichev 2015
*/

namespace JSC.Host.DomainModels.DAL
{
    using System;
    using System.Collections.Generic;

    using JSC.Host.DomainModels.EntityContexts;
    using JSC.Host.DomainModels.EntityModels;

    // todo: оставить пока как есть, вероятно, PostgreSql не поддерживает Seed method
    internal class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TestContext>
    {
        protected override void Seed(TestContext context)
        {
            var students = new List<Student>
                               {
                                   new Student
                                       {
                                           FirstMidName = "Carson",
                                           LastName = "Alexander",
                                           EnrollmentDate = DateTime.Parse("2005-09-01")
                                       },
                                   new Student
                                       {
                                           FirstMidName = "Meredith",
                                           LastName = "Alonso",
                                           EnrollmentDate = DateTime.Parse("2002-09-01")
                                       },
                                   new Student
                                       {
                                           FirstMidName = "Arturo",
                                           LastName = "Anand",
                                           EnrollmentDate = DateTime.Parse("2003-09-01")
                                       },
                                   new Student
                                       {
                                           FirstMidName = "Gytis",
                                           LastName = "Barzdukas",
                                           EnrollmentDate = DateTime.Parse("2002-09-01")
                                       },
                                   new Student
                                       {
                                           FirstMidName = "Yan",
                                           LastName = "Li",
                                           EnrollmentDate = DateTime.Parse("2002-09-01")
                                       },
                                   new Student
                                       {
                                           FirstMidName = "Peggy",
                                           LastName = "Justice",
                                           EnrollmentDate = DateTime.Parse("2001-09-01")
                                       },
                                   new Student
                                       {
                                           FirstMidName = "Laura",
                                           LastName = "Norman",
                                           EnrollmentDate = DateTime.Parse("2003-09-01")
                                       },
                                   new Student
                                       {
                                           FirstMidName = "Nino",
                                           LastName = "Olivetto",
                                           EnrollmentDate = DateTime.Parse("2005-09-01")
                                       }
                               };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
