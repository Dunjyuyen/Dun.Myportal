using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dun.Myportal.Authorization.Roles;
using Dun.Myportal.Authorization.Users;
using Dun.Myportal.MultiTenancy;
using Dun.Myportal.Domain.Exam;

namespace Dun.Myportal.EntityFrameworkCore
{
    public class MyportalDbContext : AbpZeroDbContext<Tenant, Role, User, MyportalDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyportalDbContext(DbContextOptions<MyportalDbContext> options)
            : base(options)
        {
        }
        public DbSet<ExamQuestion> ExamQuestions { get; set; } // 题目数据集合
        public DbSet<ExamType> ExamTypes { get; set; } // 题目类型数据集
        public DbSet<ExamUserError> ExamUserErrors { get; set; } // 题目类型数据集
        public DbSet<ExamGroup> ExamGroup { get; set; } // 题目类型数据集
        public DbSet<ExamLevel> ExamLevel { get; set; } // 题目类型数据集
    }
}
