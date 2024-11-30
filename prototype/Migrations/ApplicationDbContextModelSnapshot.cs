﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using prototype.Data;

#nullable disable

namespace prototype.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmergencyContact", b =>
                {
                    b.Property<int>("PICOE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PICOE_ID"));

                    b.Property<string>("PICOE_BRGY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_CONTACTNUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_DISTRICT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_FIRSTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_HOUSESTREET")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_LASTNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_MIDDLENAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_MUNICIPALITY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_RELATIONSHIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_STUDENT_ACC_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_SUFFIX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PICOE_ZIPCODE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PICOE_ID");

                    b.ToTable("PersonInCaseOfEmergency", (string)null);
                });

            modelBuilder.Entity("prototype.Models.AccountCreationModel", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("USERID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"));

                    b.Property<string>("AccStudentId")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ACC_STUDENT_ID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("EnrollmentStatus")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ENROLLMENT_STATUS");

                    b.Property<string>("Otp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("OTP");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("ReferenceStatus")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REFERENCE_STATUS");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("STATUS");

                    b.Property<string>("UserType")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USER_TYPE");

                    b.Property<string>("Verification")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VERIFICATION");

                    b.HasKey("AccountId");

                    b.ToTable("USERS", (string)null);
                });

            modelBuilder.Entity("prototype.Models.BasicInformation", b =>
                {
                    b.Property<int>("BASIC_INFO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BASIC_INFO_ID"));

                    b.Property<string>("ACCREDITATION_OF_SUBJECTS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APPLICATION_DATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APPLYING_AS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BI_STUDENT_ACC_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LRN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PREFERRED_CAMPUS1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PREFERRED_CAMPUS2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PREFERRED_CAMPUS3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PREFERRED_COURSE1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PREFERRED_COURSE2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PREFERRED_COURSE3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STRAND")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TRACK")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BASIC_INFO_ID");

                    b.ToTable("BasicInformations", (string)null);
                });

            modelBuilder.Entity("prototype.Models.Educations", b =>
                {
                    b.Property<int>("COLLEGE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("COLLEGE_ID"));

                    b.Property<string>("COLLEGE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_ADDRESS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_COURSE_YR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_DATE_GRADUATED")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_HONORS_RECEIVED")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_LOCATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_SCHOOL_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C_STUDENT_ACC_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HIGH_SCHOOL_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HS_ADDRESS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HS_COURSE_YR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HS_DATE_GRADUATE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HS_HONORS_RECEIVED")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HS_ID")
                        .HasColumnType("int");

                    b.Property<string>("HS_LOCATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HS_STUDENT_ACC_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PERSONAL_INFO_ID")
                        .HasColumnType("int");

                    b.Property<string>("TECH_VOC_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TV_ADDRESS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TV_COURSE_YR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TV_DATE_GRADUATED")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TV_HONORS_RECEIVED")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TV_ID")
                        .HasColumnType("int");

                    b.Property<string>("TV_LOCATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TV_STUDENT_ACC_ID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("COLLEGE_ID");

                    b.ToTable("Educations", (string)null);
                });

            modelBuilder.Entity("prototype.Models.Family", b =>
                {
                    b.Property<int>("FAMILY_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FAMILY_ID"));

                    b.Property<string>("FATHER_BARANGAY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_CONTACT_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_DISTRICT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_EDUCATIONAL_ATTAINMENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_FIRST_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_LAST_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_MIDDLE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_MUNICIPALITY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_OCCUPATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_STREET")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_SUFFIX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FATHER_ZIPCODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_BARANGAY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_CONTACT_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_DISTRICT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_FIRST_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_LAST_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_MIDDLE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_MUNICIPALITY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_RELATIONSHIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_STREET")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_SUFFIX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GUARDIAN_ZIPCODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_BARANGAY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_CONTACT_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_DISTRICT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_EDUCATIONAL_ATTAINMENT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_FIRST_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_LAST_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_MIDDLE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_MUNICIPALITY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_OCCUPATION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_STREET")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MOTHER_ZIPCODE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FAMILY_ID");

                    b.ToTable("Families", (string)null);
                });

            modelBuilder.Entity("prototype.Models.PersonalInformation", b =>
                {
                    b.Property<int>("PERSONAL_INFO_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PERSONAL_INFO_ID"));

                    b.Property<string>("BARANGAY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BIRTH_PLACE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CITIZENSHIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CIVIL_STATUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DATE_OF_BIRTH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DISTRICT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FIRST_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GENDER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HOUSE_STREET")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LAST_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MIDDLE_NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MUNICIPALITY")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("P_STUDENT_ACC_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RELIGION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SUFFIX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZIPCODE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PERSONAL_INFO_ID");

                    b.ToTable("PersonalInformations", (string)null);
                });

            modelBuilder.Entity("prototype.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("ACC_STUDENT_ID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENROLLMENT_STATUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OTP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PASSWORD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REFERENCE_STATUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("STATUS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("USER_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VERIFICATION")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
