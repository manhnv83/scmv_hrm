

// This file was automatically generated.
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file
// 
//     Configuration file:     "Mvc5Application1.Data.Model\App.config"
//     Connection String Name: "ScmvHrmConnectionString"
//     Connection String:      "Data Source=MANHNGUYENV;Initial Catalog=scmv_hrm;MultipleActiveResultSets=True;User Id=sa;password=123456;"

// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
//using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.DatabaseGeneratedOption;

namespace Mvc5Application1.Data.Model
{
    // ************************************************************************
    // Unit of work
    public interface IDBContextBase : IDisposable
    {
        IDbSet<BusinessUnit> BusinessUnit { get; set; } // BusinessUnit
        IDbSet<Country> Country { get; set; } // Country
        IDbSet<Function> Function { get; set; } // Function
        IDbSet<GroupGeneralUser> GroupGeneralUser { get; set; } // GroupGeneralUser
        IDbSet<hrm_m_access_auth_b> hrm_m_access_auth_b { get; set; } // hrm_m_access_auth_b
        IDbSet<hrm_m_access_auth_department> hrm_m_access_auth_department { get; set; } // hrm_m_access_auth_department
        IDbSet<hrm_m_access_auth_detail> hrm_m_access_auth_detail { get; set; } // hrm_m_access_auth_detail
        IDbSet<hrm_m_access_auth_post> hrm_m_access_auth_post { get; set; } // hrm_m_access_auth_post
        IDbSet<hrm_m_access_auth_role> hrm_m_access_auth_role { get; set; } // hrm_m_access_auth_role
        IDbSet<hrm_m_appointment> hrm_m_appointment { get; set; } // hrm_m_appointment
        IDbSet<hrm_m_appointment_condition> hrm_m_appointment_condition { get; set; } // hrm_m_appointment_condition
        IDbSet<hrm_m_appointment_detail> hrm_m_appointment_detail { get; set; } // hrm_m_appointment_detail
        IDbSet<hrm_m_appointment_detail_param> hrm_m_appointment_detail_param { get; set; } // hrm_m_appointment_detail_param
        IDbSet<hrm_m_auth> hrm_m_auth { get; set; } // hrm_m_auth
        IDbSet<hrm_m_bank> hrm_m_bank { get; set; } // hrm_m_bank
        IDbSet<hrm_m_cd> hrm_m_cd { get; set; } // hrm_m_cd
        IDbSet<hrm_m_cd_group> hrm_m_cd_group { get; set; } // hrm_m_cd_group
        IDbSet<hrm_m_company_b> hrm_m_company_b { get; set; } // hrm_m_company_b
        IDbSet<hrm_m_company_each_cd_b> hrm_m_company_each_cd_b { get; set; } // hrm_m_company_each_cd_b
        IDbSet<hrm_m_company_each_cd_group> hrm_m_company_each_cd_group { get; set; } // hrm_m_company_each_cd_group
        IDbSet<hrm_m_company_each_cd_t> hrm_m_company_each_cd_t { get; set; } // hrm_m_company_each_cd_t
        IDbSet<hrm_m_company_post_b> hrm_m_company_post_b { get; set; } // hrm_m_company_post_b
        IDbSet<hrm_m_company_post_t> hrm_m_company_post_t { get; set; } // hrm_m_company_post_t
        IDbSet<hrm_m_company_version_b> hrm_m_company_version_b { get; set; } // hrm_m_company_version_b
        IDbSet<hrm_m_country> hrm_m_country { get; set; } // hrm_m_country
        IDbSet<hrm_m_department_attach_b> hrm_m_department_attach_b { get; set; } // hrm_m_department_attach_b
        IDbSet<hrm_m_department_attach_t> hrm_m_department_attach_t { get; set; } // hrm_m_department_attach_t
        IDbSet<hrm_m_department_b> hrm_m_department_b { get; set; } // hrm_m_department_b
        IDbSet<hrm_m_department_inclusion_b> hrm_m_department_inclusion_b { get; set; } // hrm_m_department_inclusion_b
        IDbSet<hrm_m_department_t> hrm_m_department_t { get; set; } // hrm_m_department_t
        IDbSet<hrm_m_employee_b> hrm_m_employee_b { get; set; } // hrm_m_employee_b
        IDbSet<hrm_m_employee_t> hrm_m_employee_t { get; set; } // hrm_m_employee_t
        IDbSet<hrm_m_id_management> hrm_m_id_management { get; set; } // hrm_m_id_management
        IDbSet<hrm_m_list> hrm_m_list { get; set; } // hrm_m_list
        IDbSet<hrm_m_list_condition> hrm_m_list_condition { get; set; } // hrm_m_list_condition
        IDbSet<hrm_m_list_detail> hrm_m_list_detail { get; set; } // hrm_m_list_detail
        IDbSet<hrm_m_list_detail_param> hrm_m_list_detail_param { get; set; } // hrm_m_list_detail_param
        IDbSet<hrm_m_list_header> hrm_m_list_header { get; set; } // hrm_m_list_header
        IDbSet<hrm_m_postcode> hrm_m_postcode { get; set; } // hrm_m_postcode
        IDbSet<hrm_m_qualf> hrm_m_qualf { get; set; } // hrm_m_qualf
        IDbSet<hrm_m_qualf_group> hrm_m_qualf_group { get; set; } // hrm_m_qualf_group
        IDbSet<hrm_m_query> hrm_m_query { get; set; } // hrm_m_query
        IDbSet<hrm_m_query_column> hrm_m_query_column { get; set; } // hrm_m_query_column
        IDbSet<hrm_m_query_condition> hrm_m_query_condition { get; set; } // hrm_m_query_condition
        IDbSet<hrm_m_role_b> hrm_m_role_b { get; set; } // hrm_m_role_b
        IDbSet<hrm_m_role_employee> hrm_m_role_employee { get; set; } // hrm_m_role_employee
        IDbSet<hrm_m_sys_parameter> hrm_m_sys_parameter { get; set; } // hrm_m_sys_parameter
        IDbSet<hrm_m_sys_params> hrm_m_sys_params { get; set; } // hrm_m_sys_params
        IDbSet<hrm_t_admin_leave> hrm_t_admin_leave { get; set; } // hrm_t_admin_leave
        IDbSet<hrm_t_award_punition> hrm_t_award_punition { get; set; } // hrm_t_award_punition
        IDbSet<hrm_t_branch_relocation> hrm_t_branch_relocation { get; set; } // hrm_t_branch_relocation
        IDbSet<hrm_t_commute> hrm_t_commute { get; set; } // hrm_t_commute
        IDbSet<hrm_t_commute_detail> hrm_t_commute_detail { get; set; } // hrm_t_commute_detail
        IDbSet<hrm_t_contact_address> hrm_t_contact_address { get; set; } // hrm_t_contact_address
        IDbSet<hrm_t_dependent> hrm_t_dependent { get; set; } // hrm_t_dependent
        IDbSet<hrm_t_dependent_detail> hrm_t_dependent_detail { get; set; } // hrm_t_dependent_detail
        IDbSet<hrm_t_disabled> hrm_t_disabled { get; set; } // hrm_t_disabled
        IDbSet<hrm_t_disaster> hrm_t_disaster { get; set; } // hrm_t_disaster
        IDbSet<hrm_t_duties_relocation> hrm_t_duties_relocation { get; set; } // hrm_t_duties_relocation
        IDbSet<hrm_t_employee_base> hrm_t_employee_base { get; set; } // hrm_t_employee_base
        IDbSet<hrm_t_employee_other> hrm_t_employee_other { get; set; } // hrm_t_employee_other
        IDbSet<hrm_t_former_job> hrm_t_former_job { get; set; } // hrm_t_former_job
        IDbSet<hrm_t_health_checkup> hrm_t_health_checkup { get; set; } // hrm_t_health_checkup
        IDbSet<hrm_t_joining_company> hrm_t_joining_company { get; set; } // hrm_t_joining_company
        IDbSet<hrm_t_joining_contract> hrm_t_joining_contract { get; set; } // hrm_t_joining_contract
        IDbSet<hrm_t_oa_grade_relocation> hrm_t_oa_grade_relocation { get; set; } // hrm_t_oa_grade_relocation
        IDbSet<hrm_t_oa_qualf_relocation> hrm_t_oa_qualf_relocation { get; set; } // hrm_t_oa_qualf_relocation
        IDbSet<hrm_t_old_school> hrm_t_old_school { get; set; } // hrm_t_old_school
        IDbSet<hrm_t_payment> hrm_t_payment { get; set; } // hrm_t_payment
        IDbSet<hrm_t_present_address> hrm_t_present_address { get; set; } // hrm_t_present_address
        IDbSet<hrm_t_present_address_detail> hrm_t_present_address_detail { get; set; } // hrm_t_present_address_detail
        IDbSet<hrm_t_previous_illness> hrm_t_previous_illness { get; set; } // hrm_t_previous_illness
        IDbSet<hrm_t_qualf> hrm_t_qualf { get; set; } // hrm_t_qualf
        IDbSet<hrm_t_retire> hrm_t_retire { get; set; } // hrm_t_retire
        IDbSet<hrm_t_social_labor_insurance> hrm_t_social_labor_insurance { get; set; } // hrm_t_social_labor_insurance
        IDbSet<hrm_t_surety_detail> hrm_t_surety_detail { get; set; } // hrm_t_surety_detail
        IDbSet<hrm_t_temporary_transfer> hrm_t_temporary_transfer { get; set; } // hrm_t_temporary_transfer
        IDbSet<hrm_t_treatment> hrm_t_treatment { get; set; } // hrm_t_treatment
        IDbSet<hrm_t_union_executive> hrm_t_union_executive { get; set; } // hrm_t_union_executive
        IDbSet<hrm_t_union_join> hrm_t_union_join { get; set; } // hrm_t_union_join
        IDbSet<Location> Location { get; set; } // Location
        IDbSet<Permissions> Permissions { get; set; } // Permissions
        IDbSet<Project> Project { get; set; } // Project
        IDbSet<ProjectPermissions> ProjectPermissions { get; set; } // ProjectPermissions
        IDbSet<ProjectRole> ProjectRole { get; set; } // ProjectRole
        IDbSet<ProjectUser> ProjectUser { get; set; } // ProjectUser
        IDbSet<Region> Region { get; set; } // Region
        IDbSet<SecurityMatrix> SecurityMatrix { get; set; } // SecurityMatrix
        IDbSet<TimeZone> TimeZone { get; set; } // TimeZone
        IDbSet<UserProfile> UserProfile { get; set; } // UserProfile
        IDbSet<vwGroupUserRoles> vwGroupUserRoles { get; set; } // vwGroupUserRoles
        IDbSet<vwProjectUserRoles> vwProjectUserRoles { get; set; } // vwProjectUserRoles
        IDbSet<vwSecutiryMatrix> vwSecutiryMatrix { get; set; } // vwSecutiryMatrix
        IDbSet<webpages_Membership> webpages_Membership { get; set; } // webpages_Membership
        IDbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; } // webpages_OAuthMembership
        IDbSet<webpages_Roles> webpages_Roles { get; set; } // webpages_Roles

        int SaveChanges();
    }

    // ************************************************************************
    // Database context
    public partial class DBContextBase : DbContext, IDBContextBase
    {
        public IDbSet<BusinessUnit> BusinessUnit { get; set; } // BusinessUnit
        public IDbSet<Country> Country { get; set; } // Country
        public IDbSet<Function> Function { get; set; } // Function
        public IDbSet<GroupGeneralUser> GroupGeneralUser { get; set; } // GroupGeneralUser
        public IDbSet<hrm_m_access_auth_b> hrm_m_access_auth_b { get; set; } // hrm_m_access_auth_b
        public IDbSet<hrm_m_access_auth_department> hrm_m_access_auth_department { get; set; } // hrm_m_access_auth_department
        public IDbSet<hrm_m_access_auth_detail> hrm_m_access_auth_detail { get; set; } // hrm_m_access_auth_detail
        public IDbSet<hrm_m_access_auth_post> hrm_m_access_auth_post { get; set; } // hrm_m_access_auth_post
        public IDbSet<hrm_m_access_auth_role> hrm_m_access_auth_role { get; set; } // hrm_m_access_auth_role
        public IDbSet<hrm_m_appointment> hrm_m_appointment { get; set; } // hrm_m_appointment
        public IDbSet<hrm_m_appointment_condition> hrm_m_appointment_condition { get; set; } // hrm_m_appointment_condition
        public IDbSet<hrm_m_appointment_detail> hrm_m_appointment_detail { get; set; } // hrm_m_appointment_detail
        public IDbSet<hrm_m_appointment_detail_param> hrm_m_appointment_detail_param { get; set; } // hrm_m_appointment_detail_param
        public IDbSet<hrm_m_auth> hrm_m_auth { get; set; } // hrm_m_auth
        public IDbSet<hrm_m_bank> hrm_m_bank { get; set; } // hrm_m_bank
        public IDbSet<hrm_m_cd> hrm_m_cd { get; set; } // hrm_m_cd
        public IDbSet<hrm_m_cd_group> hrm_m_cd_group { get; set; } // hrm_m_cd_group
        public IDbSet<hrm_m_company_b> hrm_m_company_b { get; set; } // hrm_m_company_b
        public IDbSet<hrm_m_company_each_cd_b> hrm_m_company_each_cd_b { get; set; } // hrm_m_company_each_cd_b
        public IDbSet<hrm_m_company_each_cd_group> hrm_m_company_each_cd_group { get; set; } // hrm_m_company_each_cd_group
        public IDbSet<hrm_m_company_each_cd_t> hrm_m_company_each_cd_t { get; set; } // hrm_m_company_each_cd_t
        public IDbSet<hrm_m_company_post_b> hrm_m_company_post_b { get; set; } // hrm_m_company_post_b
        public IDbSet<hrm_m_company_post_t> hrm_m_company_post_t { get; set; } // hrm_m_company_post_t
        public IDbSet<hrm_m_company_version_b> hrm_m_company_version_b { get; set; } // hrm_m_company_version_b
        public IDbSet<hrm_m_country> hrm_m_country { get; set; } // hrm_m_country
        public IDbSet<hrm_m_department_attach_b> hrm_m_department_attach_b { get; set; } // hrm_m_department_attach_b
        public IDbSet<hrm_m_department_attach_t> hrm_m_department_attach_t { get; set; } // hrm_m_department_attach_t
        public IDbSet<hrm_m_department_b> hrm_m_department_b { get; set; } // hrm_m_department_b
        public IDbSet<hrm_m_department_inclusion_b> hrm_m_department_inclusion_b { get; set; } // hrm_m_department_inclusion_b
        public IDbSet<hrm_m_department_t> hrm_m_department_t { get; set; } // hrm_m_department_t
        public IDbSet<hrm_m_employee_b> hrm_m_employee_b { get; set; } // hrm_m_employee_b
        public IDbSet<hrm_m_employee_t> hrm_m_employee_t { get; set; } // hrm_m_employee_t
        public IDbSet<hrm_m_id_management> hrm_m_id_management { get; set; } // hrm_m_id_management
        public IDbSet<hrm_m_list> hrm_m_list { get; set; } // hrm_m_list
        public IDbSet<hrm_m_list_condition> hrm_m_list_condition { get; set; } // hrm_m_list_condition
        public IDbSet<hrm_m_list_detail> hrm_m_list_detail { get; set; } // hrm_m_list_detail
        public IDbSet<hrm_m_list_detail_param> hrm_m_list_detail_param { get; set; } // hrm_m_list_detail_param
        public IDbSet<hrm_m_list_header> hrm_m_list_header { get; set; } // hrm_m_list_header
        public IDbSet<hrm_m_postcode> hrm_m_postcode { get; set; } // hrm_m_postcode
        public IDbSet<hrm_m_qualf> hrm_m_qualf { get; set; } // hrm_m_qualf
        public IDbSet<hrm_m_qualf_group> hrm_m_qualf_group { get; set; } // hrm_m_qualf_group
        public IDbSet<hrm_m_query> hrm_m_query { get; set; } // hrm_m_query
        public IDbSet<hrm_m_query_column> hrm_m_query_column { get; set; } // hrm_m_query_column
        public IDbSet<hrm_m_query_condition> hrm_m_query_condition { get; set; } // hrm_m_query_condition
        public IDbSet<hrm_m_role_b> hrm_m_role_b { get; set; } // hrm_m_role_b
        public IDbSet<hrm_m_role_employee> hrm_m_role_employee { get; set; } // hrm_m_role_employee
        public IDbSet<hrm_m_sys_parameter> hrm_m_sys_parameter { get; set; } // hrm_m_sys_parameter
        public IDbSet<hrm_m_sys_params> hrm_m_sys_params { get; set; } // hrm_m_sys_params
        public IDbSet<hrm_t_admin_leave> hrm_t_admin_leave { get; set; } // hrm_t_admin_leave
        public IDbSet<hrm_t_award_punition> hrm_t_award_punition { get; set; } // hrm_t_award_punition
        public IDbSet<hrm_t_branch_relocation> hrm_t_branch_relocation { get; set; } // hrm_t_branch_relocation
        public IDbSet<hrm_t_commute> hrm_t_commute { get; set; } // hrm_t_commute
        public IDbSet<hrm_t_commute_detail> hrm_t_commute_detail { get; set; } // hrm_t_commute_detail
        public IDbSet<hrm_t_contact_address> hrm_t_contact_address { get; set; } // hrm_t_contact_address
        public IDbSet<hrm_t_dependent> hrm_t_dependent { get; set; } // hrm_t_dependent
        public IDbSet<hrm_t_dependent_detail> hrm_t_dependent_detail { get; set; } // hrm_t_dependent_detail
        public IDbSet<hrm_t_disabled> hrm_t_disabled { get; set; } // hrm_t_disabled
        public IDbSet<hrm_t_disaster> hrm_t_disaster { get; set; } // hrm_t_disaster
        public IDbSet<hrm_t_duties_relocation> hrm_t_duties_relocation { get; set; } // hrm_t_duties_relocation
        public IDbSet<hrm_t_employee_base> hrm_t_employee_base { get; set; } // hrm_t_employee_base
        public IDbSet<hrm_t_employee_other> hrm_t_employee_other { get; set; } // hrm_t_employee_other
        public IDbSet<hrm_t_former_job> hrm_t_former_job { get; set; } // hrm_t_former_job
        public IDbSet<hrm_t_health_checkup> hrm_t_health_checkup { get; set; } // hrm_t_health_checkup
        public IDbSet<hrm_t_joining_company> hrm_t_joining_company { get; set; } // hrm_t_joining_company
        public IDbSet<hrm_t_joining_contract> hrm_t_joining_contract { get; set; } // hrm_t_joining_contract
        public IDbSet<hrm_t_oa_grade_relocation> hrm_t_oa_grade_relocation { get; set; } // hrm_t_oa_grade_relocation
        public IDbSet<hrm_t_oa_qualf_relocation> hrm_t_oa_qualf_relocation { get; set; } // hrm_t_oa_qualf_relocation
        public IDbSet<hrm_t_old_school> hrm_t_old_school { get; set; } // hrm_t_old_school
        public IDbSet<hrm_t_payment> hrm_t_payment { get; set; } // hrm_t_payment
        public IDbSet<hrm_t_present_address> hrm_t_present_address { get; set; } // hrm_t_present_address
        public IDbSet<hrm_t_present_address_detail> hrm_t_present_address_detail { get; set; } // hrm_t_present_address_detail
        public IDbSet<hrm_t_previous_illness> hrm_t_previous_illness { get; set; } // hrm_t_previous_illness
        public IDbSet<hrm_t_qualf> hrm_t_qualf { get; set; } // hrm_t_qualf
        public IDbSet<hrm_t_retire> hrm_t_retire { get; set; } // hrm_t_retire
        public IDbSet<hrm_t_social_labor_insurance> hrm_t_social_labor_insurance { get; set; } // hrm_t_social_labor_insurance
        public IDbSet<hrm_t_surety_detail> hrm_t_surety_detail { get; set; } // hrm_t_surety_detail
        public IDbSet<hrm_t_temporary_transfer> hrm_t_temporary_transfer { get; set; } // hrm_t_temporary_transfer
        public IDbSet<hrm_t_treatment> hrm_t_treatment { get; set; } // hrm_t_treatment
        public IDbSet<hrm_t_union_executive> hrm_t_union_executive { get; set; } // hrm_t_union_executive
        public IDbSet<hrm_t_union_join> hrm_t_union_join { get; set; } // hrm_t_union_join
        public IDbSet<Location> Location { get; set; } // Location
        public IDbSet<Permissions> Permissions { get; set; } // Permissions
        public IDbSet<Project> Project { get; set; } // Project
        public IDbSet<ProjectPermissions> ProjectPermissions { get; set; } // ProjectPermissions
        public IDbSet<ProjectRole> ProjectRole { get; set; } // ProjectRole
        public IDbSet<ProjectUser> ProjectUser { get; set; } // ProjectUser
        public IDbSet<Region> Region { get; set; } // Region
        public IDbSet<SecurityMatrix> SecurityMatrix { get; set; } // SecurityMatrix
        public IDbSet<TimeZone> TimeZone { get; set; } // TimeZone
        public IDbSet<UserProfile> UserProfile { get; set; } // UserProfile
        public IDbSet<vwGroupUserRoles> vwGroupUserRoles { get; set; } // vwGroupUserRoles
        public IDbSet<vwProjectUserRoles> vwProjectUserRoles { get; set; } // vwProjectUserRoles
        public IDbSet<vwSecutiryMatrix> vwSecutiryMatrix { get; set; } // vwSecutiryMatrix
        public IDbSet<webpages_Membership> webpages_Membership { get; set; } // webpages_Membership
        public IDbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; } // webpages_OAuthMembership
        public IDbSet<webpages_Roles> webpages_Roles { get; set; } // webpages_Roles

        static DBContextBase()
        {
            Database.SetInitializer<DBContextBase>(null);
        }

        public DBContextBase()
            : base("Name=ScmvHrmConnectionString")
        {
        InitializePartial();
        }

        public DBContextBase(string connectionString) : base(connectionString)
        {
        InitializePartial();
        }

        public DBContextBase(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        InitializePartial();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BusinessUnitConfiguration());
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new FunctionConfiguration());
            modelBuilder.Configurations.Add(new GroupGeneralUserConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_access_auth_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_access_auth_departmentConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_access_auth_detailConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_access_auth_postConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_access_auth_roleConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_appointmentConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_appointment_conditionConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_appointment_detailConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_appointment_detail_paramConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_authConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_bankConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_cdConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_cd_groupConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_company_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_company_each_cd_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_company_each_cd_groupConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_company_each_cd_tConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_company_post_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_company_post_tConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_company_version_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_countryConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_department_attach_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_department_attach_tConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_department_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_department_inclusion_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_department_tConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_employee_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_employee_tConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_id_managementConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_listConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_list_conditionConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_list_detailConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_list_detail_paramConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_list_headerConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_postcodeConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_qualfConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_qualf_groupConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_queryConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_query_columnConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_query_conditionConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_role_bConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_role_employeeConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_sys_parameterConfiguration());
            modelBuilder.Configurations.Add(new hrm_m_sys_paramsConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_admin_leaveConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_award_punitionConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_branch_relocationConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_commuteConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_commute_detailConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_contact_addressConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_dependentConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_dependent_detailConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_disabledConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_disasterConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_duties_relocationConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_employee_baseConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_employee_otherConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_former_jobConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_health_checkupConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_joining_companyConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_joining_contractConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_oa_grade_relocationConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_oa_qualf_relocationConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_old_schoolConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_paymentConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_present_addressConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_present_address_detailConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_previous_illnessConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_qualfConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_retireConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_social_labor_insuranceConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_surety_detailConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_temporary_transferConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_treatmentConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_union_executiveConfiguration());
            modelBuilder.Configurations.Add(new hrm_t_union_joinConfiguration());
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new PermissionsConfiguration());
            modelBuilder.Configurations.Add(new ProjectConfiguration());
            modelBuilder.Configurations.Add(new ProjectPermissionsConfiguration());
            modelBuilder.Configurations.Add(new ProjectRoleConfiguration());
            modelBuilder.Configurations.Add(new ProjectUserConfiguration());
            modelBuilder.Configurations.Add(new RegionConfiguration());
            modelBuilder.Configurations.Add(new SecurityMatrixConfiguration());
            modelBuilder.Configurations.Add(new TimeZoneConfiguration());
            modelBuilder.Configurations.Add(new UserProfileConfiguration());
            modelBuilder.Configurations.Add(new vwGroupUserRolesConfiguration());
            modelBuilder.Configurations.Add(new vwProjectUserRolesConfiguration());
            modelBuilder.Configurations.Add(new vwSecutiryMatrixConfiguration());
            modelBuilder.Configurations.Add(new webpages_MembershipConfiguration());
            modelBuilder.Configurations.Add(new webpages_OAuthMembershipConfiguration());
            modelBuilder.Configurations.Add(new webpages_RolesConfiguration());
        OnModelCreatingPartial(modelBuilder);
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new BusinessUnitConfiguration(schema));
            modelBuilder.Configurations.Add(new CountryConfiguration(schema));
            modelBuilder.Configurations.Add(new FunctionConfiguration(schema));
            modelBuilder.Configurations.Add(new GroupGeneralUserConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_access_auth_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_access_auth_departmentConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_access_auth_detailConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_access_auth_postConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_access_auth_roleConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_appointmentConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_appointment_conditionConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_appointment_detailConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_appointment_detail_paramConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_authConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_bankConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_cdConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_cd_groupConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_company_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_company_each_cd_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_company_each_cd_groupConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_company_each_cd_tConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_company_post_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_company_post_tConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_company_version_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_countryConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_department_attach_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_department_attach_tConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_department_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_department_inclusion_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_department_tConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_employee_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_employee_tConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_id_managementConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_listConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_list_conditionConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_list_detailConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_list_detail_paramConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_list_headerConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_postcodeConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_qualfConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_qualf_groupConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_queryConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_query_columnConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_query_conditionConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_role_bConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_role_employeeConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_sys_parameterConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_m_sys_paramsConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_admin_leaveConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_award_punitionConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_branch_relocationConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_commuteConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_commute_detailConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_contact_addressConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_dependentConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_dependent_detailConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_disabledConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_disasterConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_duties_relocationConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_employee_baseConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_employee_otherConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_former_jobConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_health_checkupConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_joining_companyConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_joining_contractConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_oa_grade_relocationConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_oa_qualf_relocationConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_old_schoolConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_paymentConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_present_addressConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_present_address_detailConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_previous_illnessConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_qualfConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_retireConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_social_labor_insuranceConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_surety_detailConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_temporary_transferConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_treatmentConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_union_executiveConfiguration(schema));
            modelBuilder.Configurations.Add(new hrm_t_union_joinConfiguration(schema));
            modelBuilder.Configurations.Add(new LocationConfiguration(schema));
            modelBuilder.Configurations.Add(new PermissionsConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectPermissionsConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectRoleConfiguration(schema));
            modelBuilder.Configurations.Add(new ProjectUserConfiguration(schema));
            modelBuilder.Configurations.Add(new RegionConfiguration(schema));
            modelBuilder.Configurations.Add(new SecurityMatrixConfiguration(schema));
            modelBuilder.Configurations.Add(new TimeZoneConfiguration(schema));
            modelBuilder.Configurations.Add(new UserProfileConfiguration(schema));
            modelBuilder.Configurations.Add(new vwGroupUserRolesConfiguration(schema));
            modelBuilder.Configurations.Add(new vwProjectUserRolesConfiguration(schema));
            modelBuilder.Configurations.Add(new vwSecutiryMatrixConfiguration(schema));
            modelBuilder.Configurations.Add(new webpages_MembershipConfiguration(schema));
            modelBuilder.Configurations.Add(new webpages_OAuthMembershipConfiguration(schema));
            modelBuilder.Configurations.Add(new webpages_RolesConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
    }

    // ************************************************************************
    // POCO classes

    // BusinessUnit
    public partial class BusinessUnit : object
    {
        public int BusinessUnitId { get; set; } // BusinessUnitId (Primary key)
        public string BusinessUnitName { get; set; } // BusinessUnitName
        public int RegionId { get; set; } // RegionId
        public int? SortOrder { get; set; } // SortOrder

        // Reverse navigation
        public virtual ICollection<Country> Country { get; set; } // Country.FK_Country_BusinessUnit
        public virtual ICollection<GroupGeneralUser> GroupGeneralUser { get; set; } // GroupGeneralUser.FK_GroupGeneralUser_BusinessUnit

        // Foreign keys
        public virtual Region Region { get; set; } // FK_BusinessUnit_Region

        public BusinessUnit()
        {
            Country = new List<Country>();
            GroupGeneralUser = new List<GroupGeneralUser>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Country
    public partial class Country : object
    {
        public int CountryId { get; set; } // CountryId (Primary key)
        public string CountryName { get; set; } // CountryName
        public int BusinessUnitId { get; set; } // BusinessUnitId
        public int? SortOrder { get; set; } // SortOrder

        // Reverse navigation
        public virtual ICollection<GroupGeneralUser> GroupGeneralUser { get; set; } // GroupGeneralUser.FK_GroupGeneralUser_Country
        public virtual ICollection<Project> Project { get; set; } // Project.FK_Project_Country

        // Foreign keys
        public virtual BusinessUnit BusinessUnit { get; set; } // FK_Country_BusinessUnit

        public Country()
        {
            GroupGeneralUser = new List<GroupGeneralUser>();
            Project = new List<Project>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Function
    public partial class Function : object
    {
        public int FunctionId { get; set; } // FunctionId (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<Permissions> Permissions { get; set; } // Permissions.FK_Permissions_Function

        public Function()
        {
            Permissions = new List<Permissions>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // GroupGeneralUser
    public partial class GroupGeneralUser : object
    {
        public int Id { get; set; } // Id (Primary key)
        public int? RegionId { get; set; } // RegionId
        public int? BusinessUnitId { get; set; } // BusinessUnitId
        public int? CountryId { get; set; } // CountryId
        public int? ProjectId { get; set; } // ProjectId
        public string GroupTree { get; set; } // GroupTree
        public int UserProfileId { get; set; } // UserProfileId

        // Foreign keys
        public virtual BusinessUnit BusinessUnit { get; set; } // FK_GroupGeneralUser_BusinessUnit
        public virtual Country Country { get; set; } // FK_GroupGeneralUser_Country
        public virtual Project Project { get; set; } // FK_GroupGeneralUser_Project
        public virtual Region Region { get; set; } // FK_GroupGeneralUser_Region
        public virtual UserProfile UserProfile { get; set; } // FK_GroupGeneralUser_UserProfile
    }

    // hrm_m_access_auth_b
    public partial class hrm_m_access_auth_b : object
    {
        public Guid access_auth_cd { get; set; } // access_auth_cd (Primary key)
        public string access_auth_name { get; set; } // access_auth_name
        public string notes { get; set; } // notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_access_auth_b()
        {
            access_auth_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_access_auth_department
    public partial class hrm_m_access_auth_department : object
    {
        public Guid access_auth_cd { get; set; } // access_auth_cd (Primary key)
        public Guid? company_cd { get; set; } // company_cd
        public Guid? department_cd { get; set; } // department_cd
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_access_auth_department()
        {
            access_auth_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_access_auth_detail
    public partial class hrm_m_access_auth_detail : object
    {
        public Guid access_auth_cd { get; set; } // access_auth_cd (Primary key)
        public Guid? feature_cd { get; set; } // feature_cd
        public string access_scope_div { get; set; } // access_scope_div
        public string auth_class_div { get; set; } // auth_class_div
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_access_auth_detail()
        {
            access_auth_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_access_auth_post
    public partial class hrm_m_access_auth_post : object
    {
        public Guid access_auth_cd { get; set; } // access_auth_cd (Primary key)
        public Guid? company_cd { get; set; } // company_cd
        public Guid? post_cd { get; set; } // post_cd
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_access_auth_post()
        {
            access_auth_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_access_auth_role
    public partial class hrm_m_access_auth_role : object
    {
        public Guid access_auth_cd { get; set; } // access_auth_cd (Primary key)
        public Guid role_id { get; set; } // role_id
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_access_auth_role()
        {
            access_auth_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_appointment
    public partial class hrm_m_appointment : object
    {
        public Guid appointment_cd { get; set; } // appointment_cd (Primary key)
        public string appointment_name { get; set; } // appointment_name
        public Guid? query_cd { get; set; } // query_cd
        public string format_file_logical_name { get; set; } // format_file_logical_name
        public string format_file_physical_name { get; set; } // format_file_physical_name
        public string format_file_sheet_name { get; set; } // format_file_sheet_name
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_appointment()
        {
            appointment_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_appointment_condition
    public partial class hrm_m_appointment_condition : object
    {
        public Guid appointment_cd { get; set; } // appointment_cd (Primary key)
        public string appointment_condition_seq { get; set; } // appointment_condition_seq
        public Guid? column_id { get; set; } // column_id
        public string field_name { get; set; } // field_name
        public string field_class_div { get; set; } // field_class_div
        public string condition_class_div { get; set; } // condition_class_div
        public string condition_data_type_div { get; set; } // condition_data_type_div
        public bool? indispensable_input_flg { get; set; } // indispensable_input_flg
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_appointment_condition()
        {
            appointment_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_appointment_detail
    public partial class hrm_m_appointment_detail : object
    {
        public Guid appointment_cd { get; set; } // appointment_cd (Primary key)
        public string appointment_seq { get; set; } // appointment_seq
        public string field_name { get; set; } // field_name
        public string output_class_div { get; set; } // output_class_div
        public string output_value { get; set; } // output_value
        public bool? indicate_flg { get; set; } // indicate_flg
        public string indicate_data_type_div { get; set; } // indicate_data_type_div
        public bool? output_flg { get; set; } // output_flg
        public string cell_position { get; set; } // cell_position
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_appointment_detail()
        {
            appointment_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_appointment_detail_param
    public partial class hrm_m_appointment_detail_param : object
    {
        public Guid appointment_cd { get; set; } // appointment_cd (Primary key)
        public string appointment_seq { get; set; } // appointment_seq
        public decimal param_detail_no { get; set; } // param_detail_no
        public string param_class_div { get; set; } // param_class_div
        public string param_value { get; set; } // param_value
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_appointment_detail_param()
        {
            appointment_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_auth
    public partial class hrm_m_auth : object
    {
        public Guid feature_cd { get; set; } // feature_cd (Primary key)
        public string access_scope_div { get; set; } // access_scope_div
        public string auth_class_div { get; set; } // auth_class_div
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_auth()
        {
            feature_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_bank
    public partial class hrm_m_bank : object
    {
        public Guid bank_cd { get; set; } // bank_cd (Primary key)
        public string bank_name { get; set; } // bank_name
        public string bank_name_kana { get; set; } // bank_name_kana
        public string branch_office_name { get; set; } // branch_office_name
        public string branch_office_name_kana { get; set; } // branch_office_name_kana
        public bool? delete_flg { get; set; } // delete_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_bank()
        {
            bank_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_cd
    public partial class hrm_m_cd : object
    {
        public Guid cd_group_cd { get; set; } // cd_group_cd (Primary key)
        public string cd { get; set; } // cd
        public string cd_name { get; set; } // cd_name
        public string edit_possible_div { get; set; } // edit_possible_div
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public bool? delete_flg { get; set; } // delete_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_cd()
        {
            cd_group_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_cd_group
    public partial class hrm_m_cd_group : object
    {
        public Guid cd_group_cd { get; set; } // cd_group_cd (Primary key)
        public string cd_group_name { get; set; } // cd_group_name
        public string edit_possible_div { get; set; } // edit_possible_div
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public bool? delete_flg { get; set; } // delete_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_cd_group()
        {
            cd_group_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_b
    public partial class hrm_m_company_b : object
    {
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_company_b()
        {
            company_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_each_cd_b
    public partial class hrm_m_company_each_cd_b : object
    {
        public Guid cd_group_cd { get; set; } // cd_group_cd (Primary key)
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid cd { get; set; } // cd (Primary key)
        public string edit_possible_div { get; set; } // edit_possible_div
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public bool? delete_flg { get; set; } // delete_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_company_each_cd_group
    public partial class hrm_m_company_each_cd_group : object
    {
        public Guid cd_group_cd { get; set; } // cd_group_cd (Primary key)
        public string cd_group_name { get; set; } // cd_group_name
        public string edit_possible_div { get; set; } // edit_possible_div
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public bool? delete_flg { get; set; } // delete_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_company_each_cd_group()
        {
            cd_group_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_each_cd_t
    public partial class hrm_m_company_each_cd_t : object
    {
        public Guid cd_group_cd { get; set; } // cd_group_cd (Primary key)
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid cd { get; set; } // cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public string cd_name { get; set; } // cd_name
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_company_post_b
    public partial class hrm_m_company_post_b : object
    {
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid post_cd { get; set; } // post_cd (Primary key)
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_company_post_t
    public partial class hrm_m_company_post_t : object
    {
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid post_cd { get; set; } // post_cd (Primary key)
        public Guid term_cd { get; set; } // term_cd (Primary key)
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public string post_name { get; set; } // post_name
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_company_version_b
    public partial class hrm_m_company_version_b : object
    {
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid version_cd { get; set; } // version_cd (Primary key)
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public string notes { get; set; } // notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_country
    public partial class hrm_m_country : object
    {
        public Guid country_cd { get; set; } // country_cd (Primary key)
        public string country_name { get; set; } // country_name
        public long? sort_key { get; set; } // sort_key
        public bool? delete_flg { get; set; } // delete_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_country()
        {
            country_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_department_attach_b
    public partial class hrm_m_department_attach_b : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid department_cd { get; set; } // department_cd (Primary key)
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_department_attach_t
    public partial class hrm_m_department_attach_t : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid department_cd { get; set; } // department_cd (Primary key)
        public Guid term_cd { get; set; } // term_cd (Primary key)
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public Guid? post_cd { get; set; } // post_cd
        public bool? post_executive_flg { get; set; } // post_executive_flg
        public bool? main_attach_flg { get; set; } // main_attach_flg
        public bool? attach_change_flg { get; set; } // attach_change_flg
        public bool? post_change_flg { get; set; } // post_change_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_department_b
    public partial class hrm_m_department_b : object
    {
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid department_cd { get; set; } // department_cd (Primary key)
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_department_inclusion_b
    public partial class hrm_m_department_inclusion_b : object
    {
        public Guid company_cd { get; set; } // company_cd (Primary key)
        public Guid version_cd { get; set; } // version_cd (Primary key)
        public Guid parent_department_cd { get; set; } // parent_department_cd (Primary key)
        public Guid department_cd { get; set; } // department_cd (Primary key)
        public decimal? depth { get; set; } // depth
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_department_t
    public partial class hrm_m_department_t : object
    {
        public Guid? company_cd { get; set; } // company_cd
        public Guid department_cd { get; set; } // department_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public string department_name { get; set; } // department_name
        public string department_name_kana { get; set; } // department_name_kana
        public string department_name_eng { get; set; } // department_name_eng
        public string tel_no { get; set; } // tel_no
        public string fax_no { get; set; } // fax_no
        public string extension_tel_no { get; set; } // extension_tel_no
        public string extension_fax_no { get; set; } // extension_fax_no
        public string address_country_cd1 { get; set; } // address_country_cd1
        public string address_postcode1 { get; set; } // address_postcode1
        public string address_prefecture_name1 { get; set; } // address_prefecture_name1
        public string address_city_name1 { get; set; } // address_city_name1
        public string address_town_name1 { get; set; } // address_town_name1
        public string address_block_no_name1 { get; set; } // address_block_no_name1
        public string address_prefecture_name_kana1 { get; set; } // address_prefecture_name_kana1
        public string address_city_name_kana1 { get; set; } // address_city_name_kana1
        public string address_town_name_kana1 { get; set; } // address_town_name_kana1
        public string address_block_no_name_kana1 { get; set; } // address_block_no_name_kana1
        public string address_country_cd2 { get; set; } // address_country_cd2
        public string address_postcode2 { get; set; } // address_postcode2
        public string address_prefecture_name2 { get; set; } // address_prefecture_name2
        public string address_city_name2 { get; set; } // address_city_name2
        public string address_town_name2 { get; set; } // address_town_name2
        public string address_block_no_name2 { get; set; } // address_block_no_name2
        public string address_prefecture_name_kana2 { get; set; } // address_prefecture_name_kana2
        public string address_city_name_kana2 { get; set; } // address_city_name_kana2
        public string address_town_name_kana2 { get; set; } // address_town_name_kana2
        public string address_block_no_name_kana2 { get; set; } // address_block_no_name_kana2
        public string mail_address1 { get; set; } // mail_address1
        public string mail_address2 { get; set; } // mail_address2
        public string url1 { get; set; } // url1
        public string url2 { get; set; } // url2
        public string social_insurance_office_no { get; set; } // social_insurance_office_no
        public string labor_insurance_office_no { get; set; } // labor_insurance_office_no
        public string charge_sales_department_name { get; set; } // charge_sales_department_name
        public string charge_sales_user_name { get; set; } // charge_sales_user_name
        public string charge_sales_tel_no { get; set; } // charge_sales_tel_no
        public string charge_sales_fax_no { get; set; } // charge_sales_fax_no
        public string charge_sales_mail_address { get; set; } // charge_sales_mail_address
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_employee_b
    public partial class hrm_m_employee_b : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_employee_b()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_employee_t
    public partial class hrm_m_employee_t : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public string employee_name { get; set; } // employee_name
        public string employee_name_kana { get; set; } // employee_name_kana
        public string employee_name_eng { get; set; } // employee_name_eng
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_id_management
    public partial class hrm_m_id_management : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid id_class_div { get; set; } // id_class_div
        public Guid? id { get; set; } // id
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_id_management()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list
    public partial class hrm_m_list : object
    {
        public Guid list_cd { get; set; } // list_cd (Primary key)
        public string list_name { get; set; } // list_name
        public Guid? query_cd { get; set; } // query_cd
        public string format_file_logical_name { get; set; } // format_file_logical_name
        public string format_file_physical_name { get; set; } // format_file_physical_name
        public string format_file_sheet_name { get; set; } // format_file_sheet_name
        public decimal? data_alignment_start_row { get; set; } // data_alignment_start_row
        public decimal? data_alignment_end_row { get; set; } // data_alignment_end_row
        public decimal? data_alignment_row_count { get; set; } // data_alignment_row_count
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_list()
        {
            list_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list_condition
    public partial class hrm_m_list_condition : object
    {
        public Guid list_cd { get; set; } // list_cd (Primary key)
        public string list_condition_seq { get; set; } // list_condition_seq
        public Guid? column_id { get; set; } // column_id
        public string field_name { get; set; } // field_name
        public string field_class_div { get; set; } // field_class_div
        public string condition_class_div { get; set; } // condition_class_div
        public string condition_data_type_div { get; set; } // condition_data_type_div
        public bool? indispensable_input_flg { get; set; } // indispensable_input_flg
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_list_condition()
        {
            list_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list_detail
    public partial class hrm_m_list_detail : object
    {
        public Guid list_cd { get; set; } // list_cd (Primary key)
        public decimal list_detail_no { get; set; } // list_detail_no
        public string output_class_div { get; set; } // output_class_div
        public string output_value { get; set; } // output_value
        public string indicate_data_type_div { get; set; } // indicate_data_type_div
        public string cell_position { get; set; } // cell_position
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_list_detail()
        {
            list_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list_detail_param
    public partial class hrm_m_list_detail_param : object
    {
        public Guid list_cd { get; set; } // list_cd (Primary key)
        public decimal list_detail_no { get; set; } // list_detail_no
        public decimal param_detail_no { get; set; } // param_detail_no
        public string param_class_div { get; set; } // param_class_div
        public string param_value { get; set; } // param_value
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_list_detail_param()
        {
            list_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list_header
    public partial class hrm_m_list_header : object
    {
        public Guid list_cd { get; set; } // list_cd (Primary key)
        public decimal list_header_detail_no { get; set; } // list_header_detail_no
        public string header_output_class_div { get; set; } // header_output_class_div
        public string output_value { get; set; } // output_value
        public string indicate_data_type_div { get; set; } // indicate_data_type_div
        public string cell_position { get; set; } // cell_position
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_list_header()
        {
            list_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_postcode
    public partial class hrm_m_postcode : object
    {
        public Guid country_cd { get; set; } // country_cd
        public string postcode_seq { get; set; } // postcode_seq
        public Guid postcode { get; set; } // postcode (Primary key)
        public string prefecture_name { get; set; } // prefecture_name
        public string city_name { get; set; } // city_name
        public string town_name { get; set; } // town_name
        public string prefecture_name_kana { get; set; } // prefecture_name_kana
        public string city_name_kana { get; set; } // city_name_kana
        public string town_name_kana { get; set; } // town_name_kana
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_postcode()
        {
            country_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_qualf
    public partial class hrm_m_qualf : object
    {
        public Guid qualf_group_cd { get; set; } // qualf_group_cd (Primary key)
        public Guid qualf_cd { get; set; } // qualf_cd (Primary key)
        public string qualf_name { get; set; } // qualf_name
        public bool? delete_flg { get; set; } // delete_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_qualf_group
    public partial class hrm_m_qualf_group : object
    {
        public Guid qualf_group_cd { get; set; } // qualf_group_cd (Primary key)
        public string qualf_group_name { get; set; } // qualf_group_name
        public bool? delete_flg { get; set; } // delete_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_qualf_group()
        {
            qualf_group_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_query
    public partial class hrm_m_query : object
    {
        public Guid query_cd { get; set; } // query_cd (Primary key)
        public string query_name { get; set; } // query_name
        public string sql_statement { get; set; } // sql_statement
        public string notes { get; set; } // notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_query()
        {
            query_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_query_column
    public partial class hrm_m_query_column : object
    {
        public Guid query_cd { get; set; } // query_cd (Primary key)
        public decimal query_column_detail_no { get; set; } // query_column_detail_no
        public Guid? column_id { get; set; } // column_id
        public string column_name { get; set; } // column_name
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_query_column()
        {
            query_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_query_condition
    public partial class hrm_m_query_condition : object
    {
        public Guid query_cd { get; set; } // query_cd (Primary key)
        public decimal query_condition_detail_no { get; set; } // query_condition_detail_no
        public string field_name { get; set; } // field_name
        public string field_class_div { get; set; } // field_class_div
        public string condition_data_type_div { get; set; } // condition_data_type_div
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_query_condition()
        {
            query_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_role_b
    public partial class hrm_m_role_b : object
    {
        public Guid role_id { get; set; } // role_id (Primary key)
        public string role_name { get; set; } // role_name
        public string notes { get; set; } // notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_role_employee
    public partial class hrm_m_role_employee : object
    {
        public Guid role_id { get; set; } // role_id (Primary key)
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_m_sys_parameter
    public partial class hrm_m_sys_parameter : object
    {
        public Guid sys_parameter_cd { get; set; } // sys_parameter_cd (Primary key)
        public string sys_parameter_name { get; set; } // sys_parameter_name
        public string sys_parameter_value { get; set; } // sys_parameter_value
        public string notes { get; set; } // notes
        public long? sort_key { get; set; } // sort_key
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_m_sys_parameter()
        {
            sys_parameter_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_sys_params
    public partial class hrm_m_sys_params : object
    {
        public Guid sys_parameter_cd { get; set; } // sys_parameter_cd (Primary key)
        public string sys_parameter_nm { get; set; } // sys_parameter_nm
        public string sys_parameter_value { get; set; } // sys_parameter_value
        public string sys_parameter_comment { get; set; } // sys_parameter_comment
        public decimal? sort_no { get; set; } // sort_no
        public Guid? last_update_user_cd { get; set; } // last_update_user_cd
        public DateTime? last_update_ymdhms { get; set; } // last_update_ymdhms

        public hrm_m_sys_params()
        {
            sys_parameter_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_admin_leave
    public partial class hrm_t_admin_leave : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid term_cd { get; set; } // term_cd (Primary key)
        public DateTime? admin_leave_start_date { get; set; } // admin_leave_start_date
        public DateTime? admin_leave_end_date { get; set; } // admin_leave_end_date
        public bool? service_years_deduction_flg { get; set; } // service_years_deduction_flg
        public string admin_leave_reason_notes { get; set; } // admin_leave_reason_notes
        public string admin_leave_special_affair { get; set; } // admin_leave_special_affair
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_award_punition
    public partial class hrm_t_award_punition : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string award_punition_seq { get; set; } // award_punition_seq
        public string award_punition_class_div { get; set; } // award_punition_class_div
        public string award_punition_name { get; set; } // award_punition_name
        public DateTime? award_punition_start_date { get; set; } // award_punition_start_date
        public DateTime? award_punition_end_date { get; set; } // award_punition_end_date
        public string award_punition_reason_notes { get; set; } // award_punition_reason_notes
        public string award_punition_detail_notes { get; set; } // award_punition_detail_notes
        public string award_punition_special_affair { get; set; } // award_punition_special_affair
        public string notes { get; set; } // notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_award_punition()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_branch_relocation
    public partial class hrm_t_branch_relocation : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid term_cd { get; set; } // term_cd (Primary key)
        public DateTime? branch_start_date { get; set; } // branch_start_date
        public DateTime? branch_end_date { get; set; } // branch_end_date
        public Guid? company_cd { get; set; } // company_cd
        public Guid? branch_cd { get; set; } // branch_cd
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_commute
    public partial class hrm_t_commute : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid term_cd { get; set; } // term_cd (Primary key)
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public string payment_class_div { get; set; } // payment_class_div
        public string payment_measure_div { get; set; } // payment_measure_div
        public DateTime? payment_date { get; set; } // payment_date
        public decimal? tax_free_sum_amnt { get; set; } // tax_free_sum_amnt
        public decimal? tax_sum_amnt { get; set; } // tax_sum_amnt
        public decimal? refundable_sum_amnt { get; set; } // refundable_sum_amnt
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_commute_detail
    public partial class hrm_t_commute_detail : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid term_cd { get; set; } // term_cd (Primary key)
        public decimal pathway_order { get; set; } // pathway_order
        public string commute_mean_div { get; set; } // commute_mean_div
        public string route_name { get; set; } // route_name
        public string departure_area_name { get; set; } // departure_area_name
        public string destination_area_name { get; set; } // destination_area_name
        public decimal? distance_count { get; set; } // distance_count
        public decimal? time_minute_count { get; set; } // time_minute_count
        public string through_name { get; set; } // through_name
        public string fare_term_div { get; set; } // fare_term_div
        public decimal? fare_amnt { get; set; } // fare_amnt
        public decimal? tax_free_amnt { get; set; } // tax_free_amnt
        public decimal? tax_amnt { get; set; } // tax_amnt
        public string refundable_reason_cause { get; set; } // refundable_reason_cause
        public decimal? refundable_amnt { get; set; } // refundable_amnt
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_contact_address
    public partial class hrm_t_contact_address : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string contact_address_name1 { get; set; } // contact_address_name1
        public string relationship_surety_div1 { get; set; } // relationship_surety_div1
        public string tel_no1 { get; set; } // tel_no1
        public string fax_no1 { get; set; } // fax_no1
        public string country_cd1 { get; set; } // country_cd1
        public string postcode1 { get; set; } // postcode1
        public string prefecture_name1 { get; set; } // prefecture_name1
        public string city_name1 { get; set; } // city_name1
        public string town_name1 { get; set; } // town_name1
        public string block_no_name1 { get; set; } // block_no_name1
        public string prefecture_name_kana1 { get; set; } // prefecture_name_kana1
        public string city_name_kana1 { get; set; } // city_name_kana1
        public string town_name_kana1 { get; set; } // town_name_kana1
        public string block_no_name_kana1 { get; set; } // block_no_name_kana1
        public string contact_address_name2 { get; set; } // contact_address_name2
        public string relationship_surety_div2 { get; set; } // relationship_surety_div2
        public string tel_no2 { get; set; } // tel_no2
        public string fax_no2 { get; set; } // fax_no2
        public string country_cd2 { get; set; } // country_cd2
        public string postcode2 { get; set; } // postcode2
        public string prefecture_name2 { get; set; } // prefecture_name2
        public string city_name2 { get; set; } // city_name2
        public string town_name2 { get; set; } // town_name2
        public string block_no_name2 { get; set; } // block_no_name2
        public string prefecture_name_kana2 { get; set; } // prefecture_name_kana2
        public string city_name_kana2 { get; set; } // city_name_kana2
        public string town_name_kana2 { get; set; } // town_name_kana2
        public string block_no_name_kana2 { get; set; } // block_no_name_kana2
        public string contact_address_name3 { get; set; } // contact_address_name3
        public string relationship_surety_div3 { get; set; } // relationship_surety_div3
        public string tel_no3 { get; set; } // tel_no3
        public string fax_no3 { get; set; } // fax_no3
        public string country_cd3 { get; set; } // country_cd3
        public string postcode3 { get; set; } // postcode3
        public string prefecture_name3 { get; set; } // prefecture_name3
        public string city_name3 { get; set; } // city_name3
        public string town_name3 { get; set; } // town_name3
        public string block_no_name3 { get; set; } // block_no_name3
        public string prefecture_name_kana3 { get; set; } // prefecture_name_kana3
        public string city_name_kana3 { get; set; } // city_name_kana3
        public string town_name_kana3 { get; set; } // town_name_kana3
        public string block_no_name_kana3 { get; set; } // block_no_name_kana3
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_contact_address()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_dependent
    public partial class hrm_t_dependent : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public bool? self_general_dp_flg { get; set; } // self_general_dp_flg
        public bool? self_special_dp_flg { get; set; } // self_special_dp_flg
        public bool? partner_general_dp_flg { get; set; } // partner_general_dp_flg
        public bool? partner_special_dp_flg { get; set; } // partner_special_dp_flg
        public bool? partner_lt_special_dp_flg { get; set; } // partner_lt_special_dp_flg
        public decimal? dependent_general_dp_count { get; set; } // dependent_general_dp_count
        public decimal? dependent_special_dp_count { get; set; } // dependent_special_dp_count
        public decimal? dependent_lt_special_dp_count { get; set; } // dependent_lt_special_dp_count
        public bool? widow_flg { get; set; } // widow_flg
        public bool? special_widow_flg { get; set; } // special_widow_flg
        public bool? widower_flg { get; set; } // widower_flg
        public bool? working_student_flg { get; set; } // working_student_flg
        public string dp_content_notes { get; set; } // dp_content_notes
        public DateTime? relocation_date { get; set; } // relocation_date
        public string relocation_cause { get; set; } // relocation_cause
        public string inhabitant_tax_payment_name { get; set; } // inhabitant_tax_payment_name
        public string tax_table_div { get; set; } // tax_table_div
        public decimal? self_annual_income_amnt { get; set; } // self_annual_income_amnt
        public decimal? partner_special_deduction_amnt { get; set; } // partner_special_deduction_amnt
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_dependent()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_dependent_detail
    public partial class hrm_t_dependent_detail : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string dependent_seq { get; set; } // dependent_seq
        public string dependent_name { get; set; } // dependent_name
        public string dependent_name_kana { get; set; } // dependent_name_kana
        public string relationship_relative_div { get; set; } // relationship_relative_div
        public string job_name { get; set; } // job_name
        public DateTime? birth_date { get; set; } // birth_date
        public DateTime? death_date { get; set; } // death_date
        public bool? lt_aged_parent_flg { get; set; } // lt_aged_parent_flg
        public Guid? housing_country_cd { get; set; } // housing_country_cd
        public string housing_postcode { get; set; } // housing_postcode
        public string housing_prefecture_name { get; set; } // housing_prefecture_name
        public string housing_city_name { get; set; } // housing_city_name
        public string housing_town_name { get; set; } // housing_town_name
        public string housing_block_no_name { get; set; } // housing_block_no_name
        public decimal? annual_income_amnt { get; set; } // annual_income_amnt
        public DateTime? relocation_date { get; set; } // relocation_date
        public string relocation_cause { get; set; } // relocation_cause
        public bool? deduction_target_flg { get; set; } // deduction_target_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_dependent_detail()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_disabled
    public partial class hrm_t_disabled : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public bool? disabled_status_flg { get; set; } // disabled_status_flg
        public string dp_grade_div { get; set; } // dp_grade_div
        public string dp_notebook_no { get; set; } // dp_notebook_no
        public DateTime? dp_notebook_issue_date { get; set; } // dp_notebook_issue_date
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_disabled()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_disaster
    public partial class hrm_t_disaster : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string disaster_seq { get; set; } // disaster_seq
        public DateTime? disaster_accrual_date { get; set; } // disaster_accrual_date
        public string disaster_class_div { get; set; } // disaster_class_div
        public bool? workmans_comp_aplct_status_flg { get; set; } // workmans_comp_aplct_status_flg
        public string special_affair { get; set; } // special_affair
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_disaster()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_duties_relocation
    public partial class hrm_t_duties_relocation : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public DateTime? duties_start_date { get; set; } // duties_start_date
        public DateTime? duties_end_date { get; set; } // duties_end_date
        public Guid? company_cd { get; set; } // company_cd
        public Guid? duties_cd { get; set; } // duties_cd
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_employee_base
    public partial class hrm_t_employee_base : object
    {
        public Guid employee_cd { get; set; } // employee_cd
        public string sex_div { get; set; } // sex_div
        public string blood_type_div { get; set; } // blood_type_div
        public string hometown_name { get; set; } // hometown_name
        public DateTime? birth_date { get; set; } // birth_date
        public string maiden_name { get; set; } // maiden_name
        public string maiden_name_kana { get; set; } // maiden_name_kana
        public string maiden_name_eng { get; set; } // maiden_name_eng
        public DateTime? marriage_date { get; set; } // marriage_date
        public bool? householder_flg { get; set; } // householder_flg
        public Guid? domi_country_cd { get; set; } // domi_country_cd
        public string domi_postcode { get; set; } // domi_postcode
        public string domi_prefecture_name { get; set; } // domi_prefecture_name
        public string domi_city_name { get; set; } // domi_city_name
        public string domi_town_name { get; set; } // domi_town_name
        public string domi_block_no_name { get; set; } // domi_block_no_name
        public string relationship_history_div { get; set; } // relationship_history_div
        public bool? single_status_flg { get; set; } // single_status_flg
        public string image_file_logical_name { get; set; } // image_file_logical_name
        public string image_file_physical_name { get; set; } // image_file_physical_name
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
        public string home_phone { get; set; } // home_phone
        public string cell_phone { get; set; } // cell_phone
        public string email { get; set; } // email
        public string address { get; set; } // address
        public string idcard_number { get; set; } // idcard_number
        public DateTime? idcard_date { get; set; } // idcard_date
        public string idcard_place { get; set; } // idcard_place
        public string license_num { get; set; } // license_num
        public string license_type { get; set; } // license_type
        public string arg1 { get; set; } // arg1
        public string arg2 { get; set; } // arg2
        public string arg3 { get; set; } // arg3
        public string arg4 { get; set; } // arg4
        public string arg5 { get; set; } // arg5
        public string arg6 { get; set; } // arg6
        public string arg7 { get; set; } // arg7
        public string arg8 { get; set; } // arg8
        public string arg9 { get; set; } // arg9
        public string arg10 { get; set; } // arg10
        public int employee_id { get; set; } // employee_id (Primary key)

        public hrm_t_employee_base()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_employee_other
    public partial class hrm_t_employee_other : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string passport_no { get; set; } // passport_no
        public DateTime? passport_time_limit_date { get; set; } // passport_time_limit_date
        public Guid? country_cd { get; set; } // country_cd
        public string extension_tel_no { get; set; } // extension_tel_no
        public string extension_fax_no { get; set; } // extension_fax_no
        public string mobile_tel_no1 { get; set; } // mobile_tel_no1
        public string mobile_tel_no2 { get; set; } // mobile_tel_no2
        public string mobile_mail_address1 { get; set; } // mobile_mail_address1
        public string mobile_mail_address2 { get; set; } // mobile_mail_address2
        public string mail_address1 { get; set; } // mail_address1
        public string mail_address2 { get; set; } // mail_address2
        public string url { get; set; } // url
        public string hobby1 { get; set; } // hobby1
        public string hobby2 { get; set; } // hobby2
        public string special_skill1 { get; set; } // special_skill1
        public string special_skill2 { get; set; } // special_skill2
        public string language_study_name { get; set; } // language_study_name
        public string holdings_company_stock { get; set; } // holdings_company_stock
        public string personal_stock { get; set; } // personal_stock
        public string special_affair1 { get; set; } // special_affair1
        public string special_affair2 { get; set; } // special_affair2
        public string special_affair3 { get; set; } // special_affair3
        public string special_affair4 { get; set; } // special_affair4
        public decimal? joining_company_rated_age { get; set; } // joining_company_rated_age
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_employee_other()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_former_job
    public partial class hrm_t_former_job : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string former_job_seq { get; set; } // former_job_seq
        public string company_name { get; set; } // company_name
        public DateTime? joining_company_date { get; set; } // joining_company_date
        public DateTime? retire_date { get; set; } // retire_date
        public string industry_name { get; set; } // industry_name
        public string post_name { get; set; } // post_name
        public string branch_name { get; set; } // branch_name
        public string notes { get; set; } // notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_former_job()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_health_checkup
    public partial class hrm_t_health_checkup : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string health_checkup_seq { get; set; } // health_checkup_seq
        public DateTime? health_checkup_date { get; set; } // health_checkup_date
        public string health_checkup_place_name { get; set; } // health_checkup_place_name
        public string body_height_hc { get; set; } // body_height_hc
        public string body_weight_hc { get; set; } // body_weight_hc
        public string vision_left_hc { get; set; } // vision_left_hc
        public string vision_right_hc { get; set; } // vision_right_hc
        public string correction_vision_left_hc { get; set; } // correction_vision_left_hc
        public string correction_vision_right_hc { get; set; } // correction_vision_right_hc
        public string color_blind_hc { get; set; } // color_blind_hc
        public string hearing_left_hc { get; set; } // hearing_left_hc
        public string hearing_right_hc { get; set; } // hearing_right_hc
        public string blood_pressure_up_hc { get; set; } // blood_pressure_up_hc
        public string blood_pressure_down_hc { get; set; } // blood_pressure_down_hc
        public string chest_radiography_hc { get; set; } // chest_radiography_hc
        public string electrocardiogram_hc { get; set; } // electrocardiogram_hc
        public string urine_check_sugar_hc { get; set; } // urine_check_sugar_hc
        public string urine_check_protein_hc { get; set; } // urine_check_protein_hc
        public string urine_hidden_blood_hc { get; set; } // urine_hidden_blood_hc
        public string blood_check_blood_pigment_hc { get; set; } // blood_check_blood_pigment_hc
        public string blood_check_blood_rbc_amnt_hc { get; set; } // blood_check_blood_rbc_amnt_hc
        public string blood_check_got_hc { get; set; } // blood_check_got_hc
        public string blood_check_gpt_hc { get; set; } // blood_check_gpt_hc
        public string blood_check_gtp_hc { get; set; } // blood_check_gtp_hc
        public string blood_check_cholesterol_hc { get; set; } // blood_check_cholesterol_hc
        public string blood_check_neutral_fat_hc { get; set; } // blood_check_neutral_fat_hc
        public string health_interview_notes { get; set; } // health_interview_notes
        public string notes { get; set; } // notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_health_checkup()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_joining_company
    public partial class hrm_t_joining_company : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public DateTime? joining_company_date { get; set; } // joining_company_date
        public string recruitment_class_div { get; set; } // recruitment_class_div
        public string recruitment_area_name { get; set; } // recruitment_area_name
        public string introduction_user_name { get; set; } // introduction_user_name
        public string relationship_introduction_div { get; set; } // relationship_introduction_div
        public DateTime? contract_start_date { get; set; } // contract_start_date
        public DateTime? contract_end_date { get; set; } // contract_end_date
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_joining_company()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_joining_contract
    public partial class hrm_t_joining_contract : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid contract_cd { get; set; } // contract_cd (Primary key)
        public DateTime? contract_start_date { get; set; } // contract_start_date
        public DateTime? contract_end_date { get; set; } // contract_end_date
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_oa_grade_relocation
    public partial class hrm_t_oa_grade_relocation : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public DateTime? oa_grade_start_date { get; set; } // oa_grade_start_date
        public DateTime? oa_grade_end_date { get; set; } // oa_grade_end_date
        public Guid? company_cd { get; set; } // company_cd
        public Guid? oa_grade_cd { get; set; } // oa_grade_cd
        public string oa_grade_raise_div { get; set; } // oa_grade_raise_div
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
        public int? seniority_cd { get; set; } // seniority_cd
    }

    // hrm_t_oa_qualf_relocation
    public partial class hrm_t_oa_qualf_relocation : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public DateTime? oa_qualf_start_date { get; set; } // oa_qualf_start_date
        public DateTime? oa_qualf_end_date { get; set; } // oa_qualf_end_date
        public Guid? company_cd { get; set; } // company_cd
        public Guid? oa_qualf_cd { get; set; } // oa_qualf_cd
        public string oa_qualf_raise_div { get; set; } // oa_qualf_raise_div
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_old_school
    public partial class hrm_t_old_school : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string old_school_seq { get; set; } // old_school_seq
        public string school_name { get; set; } // school_name
        public string faculty_name { get; set; } // faculty_name
        public string subject_name { get; set; } // subject_name
        public string laboratory_name { get; set; } // laboratory_name
        public string school_class_div { get; set; } // school_class_div
        public DateTime? entrance_date { get; set; } // entrance_date
        public DateTime? graduation_date { get; set; } // graduation_date
        public string graduation_status_div { get; set; } // graduation_status_div
        public string course_class_div { get; set; } // course_class_div
        public string day_evening_class_div { get; set; } // day_evening_class_div
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_old_school()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_payment
    public partial class hrm_t_payment : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public string payment_recipient_div1 { get; set; } // payment_recipient_div1
        public string bank_cd1 { get; set; } // bank_cd1
        public string deposit_item_div1 { get; set; } // deposit_item_div1
        public string account_no1 { get; set; } // account_no1
        public string bank_account_name1 { get; set; } // bank_account_name1
        public string po_name1 { get; set; } // po_name1
        public string deposit_sign1 { get; set; } // deposit_sign1
        public string deposit_no1 { get; set; } // deposit_no1
        public string po_account_name1 { get; set; } // po_account_name1
        public decimal? salary_transfer_fixed_amnt1 { get; set; } // salary_transfer_fixed_amnt1
        public decimal? bonus_transfer_fixed_amnt1 { get; set; } // bonus_transfer_fixed_amnt1
        public string payment_recipient_div2 { get; set; } // payment_recipient_div2
        public string bank_cd2 { get; set; } // bank_cd2
        public string deposit_item_div2 { get; set; } // deposit_item_div2
        public string account_no2 { get; set; } // account_no2
        public string bank_account_name2 { get; set; } // bank_account_name2
        public string po_name2 { get; set; } // po_name2
        public string deposit_sign2 { get; set; } // deposit_sign2
        public string deposit_no2 { get; set; } // deposit_no2
        public string po_account_name2 { get; set; } // po_account_name2
        public decimal? salary_transfer_fixed_amnt2 { get; set; } // salary_transfer_fixed_amnt2
        public decimal? bonus_transfer_fixed_amnt2 { get; set; } // bonus_transfer_fixed_amnt2
        public string payment_recipient_div3 { get; set; } // payment_recipient_div3
        public string bank_cd3 { get; set; } // bank_cd3
        public string deposit_item_div3 { get; set; } // deposit_item_div3
        public string account_no3 { get; set; } // account_no3
        public string bank_account_name3 { get; set; } // bank_account_name3
        public string po_name3 { get; set; } // po_name3
        public string deposit_sign3 { get; set; } // deposit_sign3
        public string deposit_no3 { get; set; } // deposit_no3
        public string po_account_name3 { get; set; } // po_account_name3
        public string payment_recipient_target_div4 { get; set; } // payment_recipient_target_div4
        public string payment_recipient_div4 { get; set; } // payment_recipient_div4
        public string bank_cd4 { get; set; } // bank_cd4
        public string deposit_item_div4 { get; set; } // deposit_item_div4
        public string account_no4 { get; set; } // account_no4
        public string bank_account_name4 { get; set; } // bank_account_name4
        public string po_name4 { get; set; } // po_name4
        public string deposit_sign4 { get; set; } // deposit_sign4
        public string deposit_no4 { get; set; } // deposit_no4
        public string po_account_name4 { get; set; } // po_account_name4
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_present_address
    public partial class hrm_t_present_address : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public DateTime? start_date { get; set; } // start_date
        public DateTime? end_date { get; set; } // end_date
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_present_address_detail
    public partial class hrm_t_present_address_detail : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public string housing_class_div { get; set; } // housing_class_div
        public string housing_status_div { get; set; } // housing_status_div
        public Guid? country_cd { get; set; } // country_cd
        public string postcode { get; set; } // postcode
        public string prefecture_name { get; set; } // prefecture_name
        public string city_name { get; set; } // city_name
        public string town_name { get; set; } // town_name
        public string block_no_name { get; set; } // block_no_name
        public string prefecture_name_kana { get; set; } // prefecture_name_kana
        public string city_name_kana { get; set; } // city_name_kana
        public string town_name_kana { get; set; } // town_name_kana
        public string block_no_name_kana { get; set; } // block_no_name_kana
        public string tel_no { get; set; } // tel_no
        public string fax_no { get; set; } // fax_no
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_previous_illness
    public partial class hrm_t_previous_illness : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string previous_illness_seq { get; set; } // previous_illness_seq
        public string previous_illness_name { get; set; } // previous_illness_name
        public DateTime? previous_illness_attack_date { get; set; } // previous_illness_attack_date
        public DateTime? previous_illness_cure_date { get; set; } // previous_illness_cure_date
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_previous_illness()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_qualf
    public partial class hrm_t_qualf : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string qualf_seq { get; set; } // qualf_seq
        public Guid? qualf_group_cd { get; set; } // qualf_group_cd
        public Guid? qualf_cd { get; set; } // qualf_cd
        public DateTime? qualf_take_date { get; set; } // qualf_take_date
        public DateTime? qualf_update_date { get; set; } // qualf_update_date
        public DateTime? qualf_valid_time_limit_date { get; set; } // qualf_valid_time_limit_date
        public string qualf_certification_no_name { get; set; } // qualf_certification_no_name
        public bool? qualf_allowance_flg { get; set; } // qualf_allowance_flg
        public string special_affair { get; set; } // special_affair
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_qualf()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_retire
    public partial class hrm_t_retire : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public DateTime? retire_date { get; set; } // retire_date
        public string retire_cause { get; set; } // retire_cause
        public decimal? sevp_amnt { get; set; } // sevp_amnt
        public decimal? retire_point_count { get; set; } // retire_point_count
        public bool? ob_society_join_status_flg { get; set; } // ob_society_join_status_flg
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_retire()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_social_labor_insurance
    public partial class hrm_t_social_labor_insurance : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string ntnl_pnsn_base_no { get; set; } // ntnl_pnsn_base_no
        public DateTime? ntnl_pnsn_base_take_date { get; set; } // ntnl_pnsn_base_take_date
        public DateTime? ntnl_pnsn_base_loss_date { get; set; } // ntnl_pnsn_base_loss_date
        public string hi_card_no { get; set; } // hi_card_no
        public decimal? erenow_hi_standard_rmnrt_amnt { get; set; } // erenow_hi_standard_rmnrt_amnt
        public DateTime? hi_take_date { get; set; } // hi_take_date
        public DateTime? hi_loss_date { get; set; } // hi_loss_date
        public string empm_insurance_join_status_div { get; set; } // empm_insurance_join_status_div
        public string empm_insurance_card_no { get; set; } // empm_insurance_card_no
        public bool? short_time_insured_person_flg { get; set; } // short_time_insured_person_flg
        public DateTime? empm_insurance_take_date { get; set; } // empm_insurance_take_date
        public DateTime? empm_insurance_loss_date { get; set; } // empm_insurance_loss_date
        public bool? workmans_comp_join_user_flg { get; set; } // workmans_comp_join_user_flg
        public string basic_pension_sign { get; set; } // basic_pension_sign
        public string basic_pension_notebook_no { get; set; } // basic_pension_notebook_no
        public string basic_pension_serial_no { get; set; } // basic_pension_serial_no
        public decimal? erenow_standard_rmnrt_amnt { get; set; } // erenow_standard_rmnrt_amnt
        public bool? basic_pension_join_user_flg { get; set; } // basic_pension_join_user_flg
        public DateTime? basic_pension_take_date { get; set; } // basic_pension_take_date
        public DateTime? basic_pension_loss_date { get; set; } // basic_pension_loss_date
        public string empl_pension_fund_join_user_no { get; set; } // empl_pension_fund_join_user_no
        public string empl_pension_fund_serial_no { get; set; } // empl_pension_fund_serial_no
        public decimal? empl_pension_basic_salary_amnt { get; set; } // empl_pension_basic_salary_amnt
        public bool? empl_pension_first_add_flg { get; set; } // empl_pension_first_add_flg
        public bool? empl_pension_second_add_flg { get; set; } // empl_pension_second_add_flg
        public DateTime? empl_pension_take_date { get; set; } // empl_pension_take_date
        public DateTime? empl_pension_loss_date { get; set; } // empl_pension_loss_date
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_social_labor_insurance()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_surety_detail
    public partial class hrm_t_surety_detail : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public string surety_name { get; set; } // surety_name
        public string relationship_surety_div { get; set; } // relationship_surety_div
        public string tel_no { get; set; } // tel_no
        public Guid? domi_country_cd { get; set; } // domi_country_cd
        public string domi_postcode { get; set; } // domi_postcode
        public string domi_prefecture_name { get; set; } // domi_prefecture_name
        public string domi_city_name { get; set; } // domi_city_name
        public string domi_town_name { get; set; } // domi_town_name
        public string domi_block_no_name { get; set; } // domi_block_no_name
        public Guid? address_country_cd { get; set; } // address_country_cd
        public string address_postcode { get; set; } // address_postcode
        public string address_prefecture_name { get; set; } // address_prefecture_name
        public string address_city_name { get; set; } // address_city_name
        public string address_town_name { get; set; } // address_town_name
        public string address_block_no_name { get; set; } // address_block_no_name
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_temporary_transfer
    public partial class hrm_t_temporary_transfer : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? term_cd { get; set; } // term_cd
        public DateTime? temporary_transfer_start_date { get; set; } // temporary_transfer_start_date
        public DateTime? temporary_transfer_end_date { get; set; } // temporary_transfer_end_date
        public string temporary_transfer_class_div { get; set; } // temporary_transfer_class_div
        public string company_name { get; set; } // company_name
        public string department_name { get; set; } // department_name
        public string post_name { get; set; } // post_name
        public string tel_no { get; set; } // tel_no
        public string work_name { get; set; } // work_name
        public Guid? address_country_cd { get; set; } // address_country_cd
        public string address_postcode { get; set; } // address_postcode
        public string address_prefecture_name { get; set; } // address_prefecture_name
        public string address_city_name { get; set; } // address_city_name
        public string address_town_name { get; set; } // address_town_name
        public string address_block_no_name { get; set; } // address_block_no_name
        public string address_prefecture_name_kana { get; set; } // address_prefecture_name_kana
        public string address_city_name_kana { get; set; } // address_city_name_kana
        public string address_town_name_kana { get; set; } // address_town_name_kana
        public string address_block_no_name_kana { get; set; } // address_block_no_name_kana
        public bool? abroad_work_status_flg { get; set; } // abroad_work_status_flg
        public DateTime? visa_time_limit_date { get; set; } // visa_time_limit_date
        public bool? go_alone_status_flg { get; set; } // go_alone_status_flg
        public string relocation_content_notes { get; set; } // relocation_content_notes
        public string rel_relocation_content_notes { get; set; } // rel_relocation_content_notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
    }

    // hrm_t_treatment
    public partial class hrm_t_treatment : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public Guid? company_cd { get; set; } // company_cd
        public Guid? work_place_cd { get; set; } // work_place_cd
        public Guid? work_system_cd { get; set; } // work_system_cd
        public string empm_class_div { get; set; } // empm_class_div
        public string salary_class_div { get; set; } // salary_class_div
        public bool? abroad_work_status_flg { get; set; } // abroad_work_status_flg
        public string station_name { get; set; } // station_name
        public DateTime? station_start_date { get; set; } // station_start_date
        public DateTime? station_end_date { get; set; } // station_end_date
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date
        public string grade_level { get; set; } // grade_level
        public string seniority_level { get; set; } // seniority_level
        public string school_class_div { get; set; } // school_class_div

        public hrm_t_treatment()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_union_executive
    public partial class hrm_t_union_executive : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string union_executive_seq { get; set; } // union_executive_seq
        public string union_executive_name { get; set; } // union_executive_name
        public DateTime? union_executive_start_date { get; set; } // union_executive_start_date
        public DateTime? union_executive_end_date { get; set; } // union_executive_end_date
        public bool? full_time_flg { get; set; } // full_time_flg
        public string notes { get; set; } // notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_union_executive()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_union_join
    public partial class hrm_t_union_join : object
    {
        public Guid employee_cd { get; set; } // employee_cd (Primary key)
        public string union_join_seq { get; set; } // union_join_seq
        public Guid? company_cd { get; set; } // company_cd
        public Guid? union_cd { get; set; } // union_cd
        public DateTime? union_start_date { get; set; } // union_start_date
        public DateTime? union_end_date { get; set; } // union_end_date
        public string notes { get; set; } // notes
        public Guid? record_user_cd { get; set; } // record_user_cd
        public DateTime? record_date { get; set; } // record_date

        public hrm_t_union_join()
        {
            employee_cd = System.Guid.NewGuid();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Location
    public partial class Location : object
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public string Description { get; set; } // Description
        public string Code { get; set; } // Code
        public string FullCode { get; set; } // FullCode
        public int ProjectId { get; set; } // ProjectId
        public int? LocationParent { get; set; } // LocationParent
        public int? Level { get; set; } // Level

        // Reverse navigation
        public virtual ICollection<Location> Location2 { get; set; } // Location.FK_Location_Location

        // Foreign keys
        public virtual Location Location1 { get; set; } // FK_Location_Location
        public virtual Project Project { get; set; } // FK_Location_Project

        public Location()
        {
            Location2 = new List<Location>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Permissions
    public partial class Permissions : object
    {
        public int PermissionId { get; set; } // PermissionId (Primary key)
        public int? ProjectRoleId { get; set; } // ProjectRoleId
        public int? FunctionId { get; set; } // FunctionId

        // Reverse navigation
        public virtual ICollection<ProjectPermissions> ProjectPermissions { get; set; } // ProjectPermissions.FK_ProjectPermissions_Permissions

        // Foreign keys
        public virtual Function Function { get; set; } // FK_Permissions_Function
        public virtual ProjectRole ProjectRole { get; set; } // FK_Permissions_ProjectRole

        public Permissions()
        {
            ProjectPermissions = new List<ProjectPermissions>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Project
    public partial class Project : object
    {
        public int Id { get; set; } // Id (Primary key)
        public string Name { get; set; } // Name
        public string Description { get; set; } // Description
        public string ShortName { get; set; } // ShortName
        public string FullCode { get; set; } // FullCode
        public int CountryId { get; set; } // CountryId
        public int? TimeZone { get; set; } // TimeZone

        // Reverse navigation
        public virtual ICollection<GroupGeneralUser> GroupGeneralUser { get; set; } // GroupGeneralUser.FK_GroupGeneralUser_Project
        public virtual ICollection<Location> Location { get; set; } // Location.FK_Location_Project
        public virtual ICollection<ProjectUser> ProjectUser { get; set; } // ProjectUser.FK_ProjectUser_Project

        // Foreign keys
        public virtual Country Country { get; set; } // FK_Project_Country
        public virtual TimeZone TimeZone_TimeZone { get; set; } // FK_Project_TimeZone

        public Project()
        {
            GroupGeneralUser = new List<GroupGeneralUser>();
            Location = new List<Location>();
            ProjectUser = new List<ProjectUser>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // ProjectPermissions
    public partial class ProjectPermissions : object
    {
        public int ProjectPermissionId { get; set; } // ProjectPermissionId (Primary key)
        public int? PermissionId { get; set; } // PermissionId
        public int? ProjectUserId { get; set; } // ProjectUserId

        // Foreign keys
        public virtual Permissions Permissions { get; set; } // FK_ProjectPermissions_Permissions
        public virtual ProjectUser ProjectUser { get; set; } // FK_ProjectPermissions_ProjectUser
    }

    // ProjectRole
    public partial class ProjectRole : object
    {
        public int ProjectRoleId { get; set; } // ProjectRoleId (Primary key)
        public string Name { get; set; } // Name

        // Reverse navigation
        public virtual ICollection<Permissions> Permissions { get; set; } // Permissions.FK_Permissions_ProjectRole

        public ProjectRole()
        {
            Permissions = new List<Permissions>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // ProjectUser
    public partial class ProjectUser : object
    {
        public int Id { get; set; } // Id (Primary key)
        public int ProjectId { get; set; } // ProjectId
        public int UserId { get; set; } // UserId

        // Reverse navigation
        public virtual ICollection<ProjectPermissions> ProjectPermissions { get; set; } // ProjectPermissions.FK_ProjectPermissions_ProjectUser

        // Foreign keys
        public virtual Project Project { get; set; } // FK_ProjectUser_Project
        public virtual UserProfile UserProfile { get; set; } // FK_ProjectUser_UserProfile

        public ProjectUser()
        {
            ProjectPermissions = new List<ProjectPermissions>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Region
    public partial class Region : object
    {
        public int RegionId { get; set; } // RegionId (Primary key)
        public string RegionName { get; set; } // RegionName
        public int? SortOrder { get; set; } // SortOrder

        // Reverse navigation
        public virtual ICollection<BusinessUnit> BusinessUnit { get; set; } // BusinessUnit.FK_BusinessUnit_Region
        public virtual ICollection<GroupGeneralUser> GroupGeneralUser { get; set; } // GroupGeneralUser.FK_GroupGeneralUser_Region

        public Region()
        {
            BusinessUnit = new List<BusinessUnit>();
            GroupGeneralUser = new List<GroupGeneralUser>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // SecurityMatrix
    public partial class SecurityMatrix : ITrackableEntity
    {
        public string Resource { get; set; } // Resource (Primary key)
        public string Operation { get; set; } // Operation (Primary key)
        public string Role { get; set; } // Role (Primary key)
        public bool Value { get; set; } // Value
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime? CreatedDate { get; set; } // CreatedDate
        public DateTime? ModifiedDate { get; set; } // ModifiedDate
        public string ModifiedBy { get; set; } // ModifiedBy

        public SecurityMatrix()
        {
            Value = false;
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // TimeZone
    public partial class TimeZone : object
    {
        public int TimeZoneId { get; set; } // TimeZoneId (Primary key)
        public string Name { get; set; } // Name
        public string Time { get; set; } // Time

        // Reverse navigation
        public virtual ICollection<Project> Project { get; set; } // Project.FK_Project_TimeZone

        public TimeZone()
        {
            Project = new List<Project>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // UserProfile
    public partial class UserProfile : object
    {
        public int UserId { get; set; } // UserId (Primary key)
        public string UserName { get; set; } // UserName
        public bool? IsGroupAdmin { get; set; } // IsGroupAdmin
        public DateTime? LastLogIn { get; set; } // LastLogIn

        // Reverse navigation
        public virtual ICollection<GroupGeneralUser> GroupGeneralUser { get; set; } // GroupGeneralUser.FK_GroupGeneralUser_UserProfile
        public virtual ICollection<ProjectUser> ProjectUser { get; set; } // ProjectUser.FK_ProjectUser_UserProfile
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; } // Many to many mapping

        public UserProfile()
        {
            GroupGeneralUser = new List<GroupGeneralUser>();
            ProjectUser = new List<ProjectUser>();
            webpages_Roles = new List<webpages_Roles>();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // vwGroupUserRoles
    public partial class vwGroupUserRoles : object
    {
        public int UserId { get; set; } // UserId
        public string Username { get; set; } // Username
        public string ProjectRoles { get; set; } // ProjectRoles
    }

    // vwProjectUserRoles
    public partial class vwProjectUserRoles : object
    {
        public int? viewId { get; set; } // viewId
        public int UserId { get; set; } // UserId
        public string UserName { get; set; } // UserName
        public int ProjectId { get; set; } // ProjectId
        public string ProjectRoles { get; set; } // ProjectRoles
    }

    // vwSecutiryMatrix
    public partial class vwSecutiryMatrix : object
    {
        public string FunctionName { get; set; } // FunctionName
        public int FunctionId { get; set; } // FunctionId
        public string UserName { get; set; } // UserName
        public int ProjectId { get; set; } // ProjectId
    }

    // webpages_Membership
    public partial class webpages_Membership : object
    {
        public int UserId { get; set; } // UserId (Primary key)
        public DateTime? CreateDate { get; set; } // CreateDate
        public string ConfirmationToken { get; set; } // ConfirmationToken
        public bool? IsConfirmed { get; set; } // IsConfirmed
        public DateTime? LastPasswordFailureDate { get; set; } // LastPasswordFailureDate
        public int PasswordFailuresSinceLastSuccess { get; set; } // PasswordFailuresSinceLastSuccess
        public string Password { get; set; } // Password
        public DateTime? PasswordChangedDate { get; set; } // PasswordChangedDate
        public string PasswordSalt { get; set; } // PasswordSalt
        public string PasswordVerificationToken { get; set; } // PasswordVerificationToken
        public DateTime? PasswordVerificationTokenExpirationDate { get; set; } // PasswordVerificationTokenExpirationDate

        public webpages_Membership()
        {
            IsConfirmed = false;
            PasswordFailuresSinceLastSuccess = 0;
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // webpages_OAuthMembership
    public partial class webpages_OAuthMembership : object
    {
        public string Provider { get; set; } // Provider (Primary key)
        public string ProviderUserId { get; set; } // ProviderUserId (Primary key)
        public int UserId { get; set; } // UserId
    }

    // webpages_Roles
    public partial class webpages_Roles : object
    {
        public int RoleId { get; set; } // RoleId (Primary key)
        public string RoleName { get; set; } // RoleName

        // Reverse navigation
        public virtual ICollection<UserProfile> UserProfile { get; set; } // Many to many mapping

        public webpages_Roles()
        {
            UserProfile = new List<UserProfile>();
            InitializePartial();
        }
        partial void InitializePartial();
    }


    // ************************************************************************
    // POCO Configuration

    // BusinessUnit
    internal partial class BusinessUnitConfiguration : EntityTypeConfiguration<BusinessUnit>
    {
        public BusinessUnitConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".BusinessUnit");
            HasKey(x => x.BusinessUnitId);

            Property(x => x.BusinessUnitId).HasColumnName("BusinessUnitId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BusinessUnitName).HasColumnName("BusinessUnitName").IsRequired().HasMaxLength(100);
            Property(x => x.RegionId).HasColumnName("RegionId").IsRequired();
            Property(x => x.SortOrder).HasColumnName("SortOrder").IsOptional();

            // Foreign keys
            HasRequired(a => a.Region).WithMany(b => b.BusinessUnit).HasForeignKey(c => c.RegionId); // FK_BusinessUnit_Region
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Country
    internal partial class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Country");
            HasKey(x => x.CountryId);

            Property(x => x.CountryId).HasColumnName("CountryId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CountryName).HasColumnName("CountryName").IsRequired().HasMaxLength(100);
            Property(x => x.BusinessUnitId).HasColumnName("BusinessUnitId").IsRequired();
            Property(x => x.SortOrder).HasColumnName("SortOrder").IsOptional();

            // Foreign keys
            HasRequired(a => a.BusinessUnit).WithMany(b => b.Country).HasForeignKey(c => c.BusinessUnitId); // FK_Country_BusinessUnit
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Function
    internal partial class FunctionConfiguration : EntityTypeConfiguration<Function>
    {
        public FunctionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Function");
            HasKey(x => x.FunctionId);

            Property(x => x.FunctionId).HasColumnName("FunctionId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsOptional().HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // GroupGeneralUser
    internal partial class GroupGeneralUserConfiguration : EntityTypeConfiguration<GroupGeneralUser>
    {
        public GroupGeneralUserConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".GroupGeneralUser");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RegionId).HasColumnName("RegionId").IsOptional();
            Property(x => x.BusinessUnitId).HasColumnName("BusinessUnitId").IsOptional();
            Property(x => x.CountryId).HasColumnName("CountryId").IsOptional();
            Property(x => x.ProjectId).HasColumnName("ProjectId").IsOptional();
            Property(x => x.GroupTree).HasColumnName("GroupTree").IsOptional().HasMaxLength(500);
            Property(x => x.UserProfileId).HasColumnName("UserProfileId").IsRequired();

            // Foreign keys
            HasOptional(a => a.Region).WithMany(b => b.GroupGeneralUser).HasForeignKey(c => c.RegionId); // FK_GroupGeneralUser_Region
            HasOptional(a => a.BusinessUnit).WithMany(b => b.GroupGeneralUser).HasForeignKey(c => c.BusinessUnitId); // FK_GroupGeneralUser_BusinessUnit
            HasOptional(a => a.Country).WithMany(b => b.GroupGeneralUser).HasForeignKey(c => c.CountryId); // FK_GroupGeneralUser_Country
            HasOptional(a => a.Project).WithMany(b => b.GroupGeneralUser).HasForeignKey(c => c.ProjectId); // FK_GroupGeneralUser_Project
            HasRequired(a => a.UserProfile).WithMany(b => b.GroupGeneralUser).HasForeignKey(c => c.UserProfileId); // FK_GroupGeneralUser_UserProfile
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_access_auth_b
    internal partial class hrm_m_access_auth_bConfiguration : EntityTypeConfiguration<hrm_m_access_auth_b>
    {
        public hrm_m_access_auth_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_access_auth_b");
            HasKey(x => x.access_auth_cd);

            Property(x => x.access_auth_cd).HasColumnName("access_auth_cd").IsRequired();
            Property(x => x.access_auth_name).HasColumnName("access_auth_name").IsOptional().HasMaxLength(128);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_access_auth_department
    internal partial class hrm_m_access_auth_departmentConfiguration : EntityTypeConfiguration<hrm_m_access_auth_department>
    {
        public hrm_m_access_auth_departmentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_access_auth_department");
            HasKey(x => x.access_auth_cd);

            Property(x => x.access_auth_cd).HasColumnName("access_auth_cd").IsRequired();
            Property(x => x.company_cd).HasColumnName("company_cd").IsOptional();
            Property(x => x.department_cd).HasColumnName("department_cd").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_access_auth_detail
    internal partial class hrm_m_access_auth_detailConfiguration : EntityTypeConfiguration<hrm_m_access_auth_detail>
    {
        public hrm_m_access_auth_detailConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_access_auth_detail");
            HasKey(x => x.access_auth_cd);

            Property(x => x.access_auth_cd).HasColumnName("access_auth_cd").IsRequired();
            Property(x => x.feature_cd).HasColumnName("feature_cd").IsOptional();
            Property(x => x.access_scope_div).HasColumnName("access_scope_div").IsRequired().HasMaxLength(20);
            Property(x => x.auth_class_div).HasColumnName("auth_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_access_auth_post
    internal partial class hrm_m_access_auth_postConfiguration : EntityTypeConfiguration<hrm_m_access_auth_post>
    {
        public hrm_m_access_auth_postConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_access_auth_post");
            HasKey(x => x.access_auth_cd);

            Property(x => x.access_auth_cd).HasColumnName("access_auth_cd").IsRequired();
            Property(x => x.company_cd).HasColumnName("company_cd").IsOptional();
            Property(x => x.post_cd).HasColumnName("post_cd").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_access_auth_role
    internal partial class hrm_m_access_auth_roleConfiguration : EntityTypeConfiguration<hrm_m_access_auth_role>
    {
        public hrm_m_access_auth_roleConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_access_auth_role");
            HasKey(x => x.access_auth_cd);

            Property(x => x.access_auth_cd).HasColumnName("access_auth_cd").IsRequired();
            Property(x => x.role_id).HasColumnName("role_id").IsRequired();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_appointment
    internal partial class hrm_m_appointmentConfiguration : EntityTypeConfiguration<hrm_m_appointment>
    {
        public hrm_m_appointmentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_appointment");
            HasKey(x => x.appointment_cd);

            Property(x => x.appointment_cd).HasColumnName("appointment_cd").IsRequired();
            Property(x => x.appointment_name).HasColumnName("appointment_name").IsOptional().HasMaxLength(128);
            Property(x => x.query_cd).HasColumnName("query_cd").IsOptional();
            Property(x => x.format_file_logical_name).HasColumnName("format_file_logical_name").IsOptional().HasMaxLength(128);
            Property(x => x.format_file_physical_name).HasColumnName("format_file_physical_name").IsOptional().HasMaxLength(128);
            Property(x => x.format_file_sheet_name).HasColumnName("format_file_sheet_name").IsOptional().HasMaxLength(128);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_appointment_condition
    internal partial class hrm_m_appointment_conditionConfiguration : EntityTypeConfiguration<hrm_m_appointment_condition>
    {
        public hrm_m_appointment_conditionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_appointment_condition");
            HasKey(x => x.appointment_cd);

            Property(x => x.appointment_cd).HasColumnName("appointment_cd").IsRequired();
            Property(x => x.appointment_condition_seq).HasColumnName("appointment_condition_seq").IsRequired().HasMaxLength(20);
            Property(x => x.column_id).HasColumnName("column_id").IsOptional();
            Property(x => x.field_name).HasColumnName("field_name").IsOptional().HasMaxLength(128);
            Property(x => x.field_class_div).HasColumnName("field_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.condition_class_div).HasColumnName("condition_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.condition_data_type_div).HasColumnName("condition_data_type_div").IsOptional().HasMaxLength(20);
            Property(x => x.indispensable_input_flg).HasColumnName("indispensable_input_flg").IsOptional();
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_appointment_detail
    internal partial class hrm_m_appointment_detailConfiguration : EntityTypeConfiguration<hrm_m_appointment_detail>
    {
        public hrm_m_appointment_detailConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_appointment_detail");
            HasKey(x => x.appointment_cd);

            Property(x => x.appointment_cd).HasColumnName("appointment_cd").IsRequired();
            Property(x => x.appointment_seq).HasColumnName("appointment_seq").IsRequired().HasMaxLength(20);
            Property(x => x.field_name).HasColumnName("field_name").IsOptional().HasMaxLength(128);
            Property(x => x.output_class_div).HasColumnName("output_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.output_value).HasColumnName("output_value").IsOptional().HasMaxLength(50);
            Property(x => x.indicate_flg).HasColumnName("indicate_flg").IsOptional();
            Property(x => x.indicate_data_type_div).HasColumnName("indicate_data_type_div").IsOptional().HasMaxLength(20);
            Property(x => x.output_flg).HasColumnName("output_flg").IsOptional();
            Property(x => x.cell_position).HasColumnName("cell_position").IsOptional().HasMaxLength(10);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_appointment_detail_param
    internal partial class hrm_m_appointment_detail_paramConfiguration : EntityTypeConfiguration<hrm_m_appointment_detail_param>
    {
        public hrm_m_appointment_detail_paramConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_appointment_detail_param");
            HasKey(x => x.appointment_cd);

            Property(x => x.appointment_cd).HasColumnName("appointment_cd").IsRequired();
            Property(x => x.appointment_seq).HasColumnName("appointment_seq").IsRequired().HasMaxLength(20);
            Property(x => x.param_detail_no).HasColumnName("param_detail_no").IsRequired();
            Property(x => x.param_class_div).HasColumnName("param_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.param_value).HasColumnName("param_value").IsOptional().HasMaxLength(50);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_auth
    internal partial class hrm_m_authConfiguration : EntityTypeConfiguration<hrm_m_auth>
    {
        public hrm_m_authConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_auth");
            HasKey(x => x.feature_cd);

            Property(x => x.feature_cd).HasColumnName("feature_cd").IsRequired();
            Property(x => x.access_scope_div).HasColumnName("access_scope_div").IsRequired().HasMaxLength(20);
            Property(x => x.auth_class_div).HasColumnName("auth_class_div").IsRequired().HasMaxLength(20);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_bank
    internal partial class hrm_m_bankConfiguration : EntityTypeConfiguration<hrm_m_bank>
    {
        public hrm_m_bankConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_bank");
            HasKey(x => x.bank_cd);

            Property(x => x.bank_cd).HasColumnName("bank_cd").IsRequired();
            Property(x => x.bank_name).HasColumnName("bank_name").IsOptional().HasMaxLength(128);
            Property(x => x.bank_name_kana).HasColumnName("bank_name_kana").IsOptional().HasMaxLength(128);
            Property(x => x.branch_office_name).HasColumnName("branch_office_name").IsOptional().HasMaxLength(128);
            Property(x => x.branch_office_name_kana).HasColumnName("branch_office_name_kana").IsOptional().HasMaxLength(128);
            Property(x => x.delete_flg).HasColumnName("delete_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_cd
    internal partial class hrm_m_cdConfiguration : EntityTypeConfiguration<hrm_m_cd>
    {
        public hrm_m_cdConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_cd");
            HasKey(x => x.cd_group_cd);

            Property(x => x.cd_group_cd).HasColumnName("cd_group_cd").IsRequired();
            Property(x => x.cd).HasColumnName("cd").IsRequired().HasMaxLength(20);
            Property(x => x.cd_name).HasColumnName("cd_name").IsOptional().HasMaxLength(128);
            Property(x => x.edit_possible_div).HasColumnName("edit_possible_div").IsOptional().HasMaxLength(20);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.delete_flg).HasColumnName("delete_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_cd_group
    internal partial class hrm_m_cd_groupConfiguration : EntityTypeConfiguration<hrm_m_cd_group>
    {
        public hrm_m_cd_groupConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_cd_group");
            HasKey(x => x.cd_group_cd);

            Property(x => x.cd_group_cd).HasColumnName("cd_group_cd").IsRequired();
            Property(x => x.cd_group_name).HasColumnName("cd_group_name").IsOptional().HasMaxLength(128);
            Property(x => x.edit_possible_div).HasColumnName("edit_possible_div").IsOptional().HasMaxLength(20);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.delete_flg).HasColumnName("delete_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_b
    internal partial class hrm_m_company_bConfiguration : EntityTypeConfiguration<hrm_m_company_b>
    {
        public hrm_m_company_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_company_b");
            HasKey(x => x.company_cd);

            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_each_cd_b
    internal partial class hrm_m_company_each_cd_bConfiguration : EntityTypeConfiguration<hrm_m_company_each_cd_b>
    {
        public hrm_m_company_each_cd_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_company_each_cd_b");
            HasKey(x => new { x.cd_group_cd, x.company_cd, x.cd });

            Property(x => x.cd_group_cd).HasColumnName("cd_group_cd").IsRequired();
            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.cd).HasColumnName("cd").IsRequired();
            Property(x => x.edit_possible_div).HasColumnName("edit_possible_div").IsOptional().HasMaxLength(20);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.delete_flg).HasColumnName("delete_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_each_cd_group
    internal partial class hrm_m_company_each_cd_groupConfiguration : EntityTypeConfiguration<hrm_m_company_each_cd_group>
    {
        public hrm_m_company_each_cd_groupConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_company_each_cd_group");
            HasKey(x => x.cd_group_cd);

            Property(x => x.cd_group_cd).HasColumnName("cd_group_cd").IsRequired();
            Property(x => x.cd_group_name).HasColumnName("cd_group_name").IsOptional().HasMaxLength(128);
            Property(x => x.edit_possible_div).HasColumnName("edit_possible_div").IsOptional().HasMaxLength(20);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.delete_flg).HasColumnName("delete_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_each_cd_t
    internal partial class hrm_m_company_each_cd_tConfiguration : EntityTypeConfiguration<hrm_m_company_each_cd_t>
    {
        public hrm_m_company_each_cd_tConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_company_each_cd_t");
            HasKey(x => new { x.company_cd, x.cd, x.cd_group_cd });

            Property(x => x.cd_group_cd).HasColumnName("cd_group_cd").IsRequired();
            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.cd).HasColumnName("cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.cd_name).HasColumnName("cd_name").IsOptional().HasMaxLength(128);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_post_b
    internal partial class hrm_m_company_post_bConfiguration : EntityTypeConfiguration<hrm_m_company_post_b>
    {
        public hrm_m_company_post_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_company_post_b");
            HasKey(x => new { x.company_cd, x.post_cd });

            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.post_cd).HasColumnName("post_cd").IsRequired();
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_post_t
    internal partial class hrm_m_company_post_tConfiguration : EntityTypeConfiguration<hrm_m_company_post_t>
    {
        public hrm_m_company_post_tConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_company_post_t");
            HasKey(x => new { x.company_cd, x.post_cd, x.term_cd });

            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.post_cd).HasColumnName("post_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsRequired();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.post_name).HasColumnName("post_name").IsOptional().HasMaxLength(128);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_company_version_b
    internal partial class hrm_m_company_version_bConfiguration : EntityTypeConfiguration<hrm_m_company_version_b>
    {
        public hrm_m_company_version_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_company_version_b");
            HasKey(x => new { x.company_cd, x.version_cd });

            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.version_cd).HasColumnName("version_cd").IsRequired();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_country
    internal partial class hrm_m_countryConfiguration : EntityTypeConfiguration<hrm_m_country>
    {
        public hrm_m_countryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_country");
            HasKey(x => x.country_cd);

            Property(x => x.country_cd).HasColumnName("country_cd").IsRequired();
            Property(x => x.country_name).HasColumnName("country_name").IsOptional().HasMaxLength(64);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.delete_flg).HasColumnName("delete_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_department_attach_b
    internal partial class hrm_m_department_attach_bConfiguration : EntityTypeConfiguration<hrm_m_department_attach_b>
    {
        public hrm_m_department_attach_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_department_attach_b");
            HasKey(x => new { x.department_cd, x.employee_cd, x.company_cd });

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.department_cd).HasColumnName("department_cd").IsRequired();
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_department_attach_t
    internal partial class hrm_m_department_attach_tConfiguration : EntityTypeConfiguration<hrm_m_department_attach_t>
    {
        public hrm_m_department_attach_tConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_department_attach_t");
            HasKey(x => new { x.employee_cd, x.company_cd, x.department_cd, x.term_cd });

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.department_cd).HasColumnName("department_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsRequired();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.post_cd).HasColumnName("post_cd").IsOptional();
            Property(x => x.post_executive_flg).HasColumnName("post_executive_flg").IsOptional();
            Property(x => x.main_attach_flg).HasColumnName("main_attach_flg").IsOptional();
            Property(x => x.attach_change_flg).HasColumnName("attach_change_flg").IsOptional();
            Property(x => x.post_change_flg).HasColumnName("post_change_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_department_b
    internal partial class hrm_m_department_bConfiguration : EntityTypeConfiguration<hrm_m_department_b>
    {
        public hrm_m_department_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_department_b");
            HasKey(x => new { x.company_cd, x.department_cd });

            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.department_cd).HasColumnName("department_cd").IsRequired();
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_department_inclusion_b
    internal partial class hrm_m_department_inclusion_bConfiguration : EntityTypeConfiguration<hrm_m_department_inclusion_b>
    {
        public hrm_m_department_inclusion_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_department_inclusion_b");
            HasKey(x => new { x.company_cd, x.version_cd, x.parent_department_cd, x.department_cd });

            Property(x => x.company_cd).HasColumnName("company_cd").IsRequired();
            Property(x => x.version_cd).HasColumnName("version_cd").IsRequired();
            Property(x => x.parent_department_cd).HasColumnName("parent_department_cd").IsRequired();
            Property(x => x.department_cd).HasColumnName("department_cd").IsRequired();
            Property(x => x.depth).HasColumnName("depth").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_department_t
    internal partial class hrm_m_department_tConfiguration : EntityTypeConfiguration<hrm_m_department_t>
    {
        public hrm_m_department_tConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_department_t");
            HasKey(x => x.department_cd);

            Property(x => x.company_cd).HasColumnName("company_cd").IsOptional();
            Property(x => x.department_cd).HasColumnName("department_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.department_name).HasColumnName("department_name").IsOptional().HasMaxLength(128);
            Property(x => x.department_name_kana).HasColumnName("department_name_kana").IsOptional().HasMaxLength(128);
            Property(x => x.department_name_eng).HasColumnName("department_name_eng").IsOptional().HasMaxLength(128);
            Property(x => x.tel_no).HasColumnName("tel_no").IsOptional().HasMaxLength(64);
            Property(x => x.fax_no).HasColumnName("fax_no").IsOptional().HasMaxLength(64);
            Property(x => x.extension_tel_no).HasColumnName("extension_tel_no").IsOptional().HasMaxLength(64);
            Property(x => x.extension_fax_no).HasColumnName("extension_fax_no").IsOptional().HasMaxLength(64);
            Property(x => x.address_country_cd1).HasColumnName("address_country_cd1").IsOptional().HasMaxLength(20);
            Property(x => x.address_postcode1).HasColumnName("address_postcode1").IsOptional().HasMaxLength(20);
            Property(x => x.address_prefecture_name1).HasColumnName("address_prefecture_name1").IsOptional().HasMaxLength(64);
            Property(x => x.address_city_name1).HasColumnName("address_city_name1").IsOptional().HasMaxLength(64);
            Property(x => x.address_town_name1).HasColumnName("address_town_name1").IsOptional().HasMaxLength(255);
            Property(x => x.address_block_no_name1).HasColumnName("address_block_no_name1").IsOptional().HasMaxLength(64);
            Property(x => x.address_prefecture_name_kana1).HasColumnName("address_prefecture_name_kana1").IsOptional().HasMaxLength(64);
            Property(x => x.address_city_name_kana1).HasColumnName("address_city_name_kana1").IsOptional().HasMaxLength(64);
            Property(x => x.address_town_name_kana1).HasColumnName("address_town_name_kana1").IsOptional().HasMaxLength(255);
            Property(x => x.address_block_no_name_kana1).HasColumnName("address_block_no_name_kana1").IsOptional().HasMaxLength(64);
            Property(x => x.address_country_cd2).HasColumnName("address_country_cd2").IsOptional().HasMaxLength(20);
            Property(x => x.address_postcode2).HasColumnName("address_postcode2").IsOptional().HasMaxLength(20);
            Property(x => x.address_prefecture_name2).HasColumnName("address_prefecture_name2").IsOptional().HasMaxLength(64);
            Property(x => x.address_city_name2).HasColumnName("address_city_name2").IsOptional().HasMaxLength(64);
            Property(x => x.address_town_name2).HasColumnName("address_town_name2").IsOptional().HasMaxLength(255);
            Property(x => x.address_block_no_name2).HasColumnName("address_block_no_name2").IsOptional().HasMaxLength(64);
            Property(x => x.address_prefecture_name_kana2).HasColumnName("address_prefecture_name_kana2").IsOptional().HasMaxLength(64);
            Property(x => x.address_city_name_kana2).HasColumnName("address_city_name_kana2").IsOptional().HasMaxLength(64);
            Property(x => x.address_town_name_kana2).HasColumnName("address_town_name_kana2").IsOptional().HasMaxLength(255);
            Property(x => x.address_block_no_name_kana2).HasColumnName("address_block_no_name_kana2").IsOptional().HasMaxLength(64);
            Property(x => x.mail_address1).HasColumnName("mail_address1").IsOptional().HasMaxLength(128);
            Property(x => x.mail_address2).HasColumnName("mail_address2").IsOptional().HasMaxLength(128);
            Property(x => x.url1).HasColumnName("url1").IsOptional().HasMaxLength(128);
            Property(x => x.url2).HasColumnName("url2").IsOptional().HasMaxLength(128);
            Property(x => x.social_insurance_office_no).HasColumnName("social_insurance_office_no").IsOptional().HasMaxLength(20);
            Property(x => x.labor_insurance_office_no).HasColumnName("labor_insurance_office_no").IsOptional().HasMaxLength(20);
            Property(x => x.charge_sales_department_name).HasColumnName("charge_sales_department_name").IsOptional().HasMaxLength(128);
            Property(x => x.charge_sales_user_name).HasColumnName("charge_sales_user_name").IsOptional().HasMaxLength(128);
            Property(x => x.charge_sales_tel_no).HasColumnName("charge_sales_tel_no").IsOptional().HasMaxLength(64);
            Property(x => x.charge_sales_fax_no).HasColumnName("charge_sales_fax_no").IsOptional().HasMaxLength(64);
            Property(x => x.charge_sales_mail_address).HasColumnName("charge_sales_mail_address").IsOptional().HasMaxLength(128);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_employee_b
    internal partial class hrm_m_employee_bConfiguration : EntityTypeConfiguration<hrm_m_employee_b>
    {
        public hrm_m_employee_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_employee_b");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_employee_t
    internal partial class hrm_m_employee_tConfiguration : EntityTypeConfiguration<hrm_m_employee_t>
    {
        public hrm_m_employee_tConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_employee_t");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.employee_name).HasColumnName("employee_name").IsOptional().HasMaxLength(128);
            Property(x => x.employee_name_kana).HasColumnName("employee_name_kana").IsOptional().HasMaxLength(128);
            Property(x => x.employee_name_eng).HasColumnName("employee_name_eng").IsOptional().HasMaxLength(128);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_id_management
    internal partial class hrm_m_id_managementConfiguration : EntityTypeConfiguration<hrm_m_id_management>
    {
        public hrm_m_id_managementConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_id_management");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.id_class_div).HasColumnName("id_class_div").IsRequired();
            Property(x => x.id).HasColumnName("id").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list
    internal partial class hrm_m_listConfiguration : EntityTypeConfiguration<hrm_m_list>
    {
        public hrm_m_listConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_list");
            HasKey(x => x.list_cd);

            Property(x => x.list_cd).HasColumnName("list_cd").IsRequired();
            Property(x => x.list_name).HasColumnName("list_name").IsOptional().HasMaxLength(128);
            Property(x => x.query_cd).HasColumnName("query_cd").IsOptional();
            Property(x => x.format_file_logical_name).HasColumnName("format_file_logical_name").IsOptional().HasMaxLength(128);
            Property(x => x.format_file_physical_name).HasColumnName("format_file_physical_name").IsOptional().HasMaxLength(128);
            Property(x => x.format_file_sheet_name).HasColumnName("format_file_sheet_name").IsOptional().HasMaxLength(128);
            Property(x => x.data_alignment_start_row).HasColumnName("data_alignment_start_row").IsOptional();
            Property(x => x.data_alignment_end_row).HasColumnName("data_alignment_end_row").IsOptional();
            Property(x => x.data_alignment_row_count).HasColumnName("data_alignment_row_count").IsOptional();
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list_condition
    internal partial class hrm_m_list_conditionConfiguration : EntityTypeConfiguration<hrm_m_list_condition>
    {
        public hrm_m_list_conditionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_list_condition");
            HasKey(x => x.list_cd);

            Property(x => x.list_cd).HasColumnName("list_cd").IsRequired();
            Property(x => x.list_condition_seq).HasColumnName("list_condition_seq").IsRequired().HasMaxLength(20);
            Property(x => x.column_id).HasColumnName("column_id").IsOptional();
            Property(x => x.field_name).HasColumnName("field_name").IsOptional().HasMaxLength(128);
            Property(x => x.field_class_div).HasColumnName("field_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.condition_class_div).HasColumnName("condition_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.condition_data_type_div).HasColumnName("condition_data_type_div").IsOptional().HasMaxLength(20);
            Property(x => x.indispensable_input_flg).HasColumnName("indispensable_input_flg").IsOptional();
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list_detail
    internal partial class hrm_m_list_detailConfiguration : EntityTypeConfiguration<hrm_m_list_detail>
    {
        public hrm_m_list_detailConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_list_detail");
            HasKey(x => x.list_cd);

            Property(x => x.list_cd).HasColumnName("list_cd").IsRequired();
            Property(x => x.list_detail_no).HasColumnName("list_detail_no").IsRequired();
            Property(x => x.output_class_div).HasColumnName("output_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.output_value).HasColumnName("output_value").IsOptional().HasMaxLength(50);
            Property(x => x.indicate_data_type_div).HasColumnName("indicate_data_type_div").IsOptional().HasMaxLength(20);
            Property(x => x.cell_position).HasColumnName("cell_position").IsOptional().HasMaxLength(10);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list_detail_param
    internal partial class hrm_m_list_detail_paramConfiguration : EntityTypeConfiguration<hrm_m_list_detail_param>
    {
        public hrm_m_list_detail_paramConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_list_detail_param");
            HasKey(x => x.list_cd);

            Property(x => x.list_cd).HasColumnName("list_cd").IsRequired();
            Property(x => x.list_detail_no).HasColumnName("list_detail_no").IsRequired();
            Property(x => x.param_detail_no).HasColumnName("param_detail_no").IsRequired();
            Property(x => x.param_class_div).HasColumnName("param_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.param_value).HasColumnName("param_value").IsOptional().HasMaxLength(50);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_list_header
    internal partial class hrm_m_list_headerConfiguration : EntityTypeConfiguration<hrm_m_list_header>
    {
        public hrm_m_list_headerConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_list_header");
            HasKey(x => x.list_cd);

            Property(x => x.list_cd).HasColumnName("list_cd").IsRequired();
            Property(x => x.list_header_detail_no).HasColumnName("list_header_detail_no").IsRequired();
            Property(x => x.header_output_class_div).HasColumnName("header_output_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.output_value).HasColumnName("output_value").IsOptional().HasMaxLength(50);
            Property(x => x.indicate_data_type_div).HasColumnName("indicate_data_type_div").IsOptional().HasMaxLength(20);
            Property(x => x.cell_position).HasColumnName("cell_position").IsOptional().HasMaxLength(10);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_postcode
    internal partial class hrm_m_postcodeConfiguration : EntityTypeConfiguration<hrm_m_postcode>
    {
        public hrm_m_postcodeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_postcode");
            HasKey(x => x.postcode);

            Property(x => x.country_cd).HasColumnName("country_cd").IsRequired();
            Property(x => x.postcode_seq).HasColumnName("postcode_seq").IsRequired().HasMaxLength(20);
            Property(x => x.postcode).HasColumnName("postcode").IsRequired();
            Property(x => x.prefecture_name).HasColumnName("prefecture_name").IsOptional().HasMaxLength(64);
            Property(x => x.city_name).HasColumnName("city_name").IsOptional().HasMaxLength(64);
            Property(x => x.town_name).HasColumnName("town_name").IsOptional().HasMaxLength(255);
            Property(x => x.prefecture_name_kana).HasColumnName("prefecture_name_kana").IsOptional().HasMaxLength(64);
            Property(x => x.city_name_kana).HasColumnName("city_name_kana").IsOptional().HasMaxLength(64);
            Property(x => x.town_name_kana).HasColumnName("town_name_kana").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_qualf
    internal partial class hrm_m_qualfConfiguration : EntityTypeConfiguration<hrm_m_qualf>
    {
        public hrm_m_qualfConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_qualf");
            HasKey(x => new { x.qualf_group_cd, x.qualf_cd });

            Property(x => x.qualf_group_cd).HasColumnName("qualf_group_cd").IsRequired();
            Property(x => x.qualf_cd).HasColumnName("qualf_cd").IsRequired();
            Property(x => x.qualf_name).HasColumnName("qualf_name").IsOptional().HasMaxLength(128);
            Property(x => x.delete_flg).HasColumnName("delete_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_qualf_group
    internal partial class hrm_m_qualf_groupConfiguration : EntityTypeConfiguration<hrm_m_qualf_group>
    {
        public hrm_m_qualf_groupConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_qualf_group");
            HasKey(x => x.qualf_group_cd);

            Property(x => x.qualf_group_cd).HasColumnName("qualf_group_cd").IsRequired();
            Property(x => x.qualf_group_name).HasColumnName("qualf_group_name").IsOptional().HasMaxLength(128);
            Property(x => x.delete_flg).HasColumnName("delete_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_query
    internal partial class hrm_m_queryConfiguration : EntityTypeConfiguration<hrm_m_query>
    {
        public hrm_m_queryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_query");
            HasKey(x => x.query_cd);

            Property(x => x.query_cd).HasColumnName("query_cd").IsRequired();
            Property(x => x.query_name).HasColumnName("query_name").IsOptional().HasMaxLength(128);
            Property(x => x.sql_statement).HasColumnName("sql_statement").IsOptional().HasMaxLength(4000);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_query_column
    internal partial class hrm_m_query_columnConfiguration : EntityTypeConfiguration<hrm_m_query_column>
    {
        public hrm_m_query_columnConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_query_column");
            HasKey(x => x.query_cd);

            Property(x => x.query_cd).HasColumnName("query_cd").IsRequired();
            Property(x => x.query_column_detail_no).HasColumnName("query_column_detail_no").IsRequired();
            Property(x => x.column_id).HasColumnName("column_id").IsOptional();
            Property(x => x.column_name).HasColumnName("column_name").IsOptional().HasMaxLength(128);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_query_condition
    internal partial class hrm_m_query_conditionConfiguration : EntityTypeConfiguration<hrm_m_query_condition>
    {
        public hrm_m_query_conditionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_query_condition");
            HasKey(x => x.query_cd);

            Property(x => x.query_cd).HasColumnName("query_cd").IsRequired();
            Property(x => x.query_condition_detail_no).HasColumnName("query_condition_detail_no").IsRequired();
            Property(x => x.field_name).HasColumnName("field_name").IsOptional().HasMaxLength(128);
            Property(x => x.field_class_div).HasColumnName("field_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.condition_data_type_div).HasColumnName("condition_data_type_div").IsOptional().HasMaxLength(20);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_role_b
    internal partial class hrm_m_role_bConfiguration : EntityTypeConfiguration<hrm_m_role_b>
    {
        public hrm_m_role_bConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_role_b");
            HasKey(x => x.role_id);

            Property(x => x.role_id).HasColumnName("role_id").IsRequired();
            Property(x => x.role_name).HasColumnName("role_name").IsOptional().HasMaxLength(128);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_role_employee
    internal partial class hrm_m_role_employeeConfiguration : EntityTypeConfiguration<hrm_m_role_employee>
    {
        public hrm_m_role_employeeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_role_employee");
            HasKey(x => new { x.role_id, x.employee_cd });

            Property(x => x.role_id).HasColumnName("role_id").IsRequired();
            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_sys_parameter
    internal partial class hrm_m_sys_parameterConfiguration : EntityTypeConfiguration<hrm_m_sys_parameter>
    {
        public hrm_m_sys_parameterConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_sys_parameter");
            HasKey(x => x.sys_parameter_cd);

            Property(x => x.sys_parameter_cd).HasColumnName("sys_parameter_cd").IsRequired();
            Property(x => x.sys_parameter_name).HasColumnName("sys_parameter_name").IsOptional().HasMaxLength(128);
            Property(x => x.sys_parameter_value).HasColumnName("sys_parameter_value").IsOptional().HasMaxLength(255);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.sort_key).HasColumnName("sort_key").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_m_sys_params
    internal partial class hrm_m_sys_paramsConfiguration : EntityTypeConfiguration<hrm_m_sys_params>
    {
        public hrm_m_sys_paramsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_m_sys_params");
            HasKey(x => x.sys_parameter_cd);

            Property(x => x.sys_parameter_cd).HasColumnName("sys_parameter_cd").IsRequired();
            Property(x => x.sys_parameter_nm).HasColumnName("sys_parameter_nm").IsOptional().HasMaxLength(255);
            Property(x => x.sys_parameter_value).HasColumnName("sys_parameter_value").IsOptional().HasMaxLength(255);
            Property(x => x.sys_parameter_comment).HasColumnName("sys_parameter_comment").IsOptional().HasMaxLength(255);
            Property(x => x.sort_no).HasColumnName("sort_no").IsOptional();
            Property(x => x.last_update_user_cd).HasColumnName("last_update_user_cd").IsOptional();
            Property(x => x.last_update_ymdhms).HasColumnName("last_update_ymdhms").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_admin_leave
    internal partial class hrm_t_admin_leaveConfiguration : EntityTypeConfiguration<hrm_t_admin_leave>
    {
        public hrm_t_admin_leaveConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_admin_leave");
            HasKey(x => new { x.employee_cd, x.term_cd });

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsRequired();
            Property(x => x.admin_leave_start_date).HasColumnName("admin_leave_start_date").IsOptional();
            Property(x => x.admin_leave_end_date).HasColumnName("admin_leave_end_date").IsOptional();
            Property(x => x.service_years_deduction_flg).HasColumnName("service_years_deduction_flg").IsOptional();
            Property(x => x.admin_leave_reason_notes).HasColumnName("admin_leave_reason_notes").IsOptional().HasMaxLength(255);
            Property(x => x.admin_leave_special_affair).HasColumnName("admin_leave_special_affair").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_award_punition
    internal partial class hrm_t_award_punitionConfiguration : EntityTypeConfiguration<hrm_t_award_punition>
    {
        public hrm_t_award_punitionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_award_punition");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.award_punition_seq).HasColumnName("award_punition_seq").IsRequired().HasMaxLength(20);
            Property(x => x.award_punition_class_div).HasColumnName("award_punition_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.award_punition_name).HasColumnName("award_punition_name").IsOptional().HasMaxLength(128);
            Property(x => x.award_punition_start_date).HasColumnName("award_punition_start_date").IsOptional();
            Property(x => x.award_punition_end_date).HasColumnName("award_punition_end_date").IsOptional();
            Property(x => x.award_punition_reason_notes).HasColumnName("award_punition_reason_notes").IsOptional().HasMaxLength(255);
            Property(x => x.award_punition_detail_notes).HasColumnName("award_punition_detail_notes").IsOptional().HasMaxLength(255);
            Property(x => x.award_punition_special_affair).HasColumnName("award_punition_special_affair").IsOptional().HasMaxLength(255);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_branch_relocation
    internal partial class hrm_t_branch_relocationConfiguration : EntityTypeConfiguration<hrm_t_branch_relocation>
    {
        public hrm_t_branch_relocationConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_branch_relocation");
            HasKey(x => new { x.employee_cd, x.term_cd });

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsRequired();
            Property(x => x.branch_start_date).HasColumnName("branch_start_date").IsOptional();
            Property(x => x.branch_end_date).HasColumnName("branch_end_date").IsOptional();
            Property(x => x.company_cd).HasColumnName("company_cd").IsOptional();
            Property(x => x.branch_cd).HasColumnName("branch_cd").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_commute
    internal partial class hrm_t_commuteConfiguration : EntityTypeConfiguration<hrm_t_commute>
    {
        public hrm_t_commuteConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_commute");
            HasKey(x => new { x.employee_cd, x.term_cd });

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsRequired();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.payment_class_div).HasColumnName("payment_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.payment_measure_div).HasColumnName("payment_measure_div").IsOptional().HasMaxLength(20);
            Property(x => x.payment_date).HasColumnName("payment_date").IsOptional();
            Property(x => x.tax_free_sum_amnt).HasColumnName("tax_free_sum_amnt").IsOptional();
            Property(x => x.tax_sum_amnt).HasColumnName("tax_sum_amnt").IsOptional();
            Property(x => x.refundable_sum_amnt).HasColumnName("refundable_sum_amnt").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_commute_detail
    internal partial class hrm_t_commute_detailConfiguration : EntityTypeConfiguration<hrm_t_commute_detail>
    {
        public hrm_t_commute_detailConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_commute_detail");
            HasKey(x => new { x.employee_cd, x.term_cd });

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsRequired();
            Property(x => x.pathway_order).HasColumnName("pathway_order").IsRequired();
            Property(x => x.commute_mean_div).HasColumnName("commute_mean_div").IsOptional().HasMaxLength(20);
            Property(x => x.route_name).HasColumnName("route_name").IsOptional().HasMaxLength(128);
            Property(x => x.departure_area_name).HasColumnName("departure_area_name").IsOptional().HasMaxLength(128);
            Property(x => x.destination_area_name).HasColumnName("destination_area_name").IsOptional().HasMaxLength(128);
            Property(x => x.distance_count).HasColumnName("distance_count").IsOptional();
            Property(x => x.time_minute_count).HasColumnName("time_minute_count").IsOptional();
            Property(x => x.through_name).HasColumnName("through_name").IsOptional().HasMaxLength(128);
            Property(x => x.fare_term_div).HasColumnName("fare_term_div").IsOptional().HasMaxLength(20);
            Property(x => x.fare_amnt).HasColumnName("fare_amnt").IsOptional();
            Property(x => x.tax_free_amnt).HasColumnName("tax_free_amnt").IsOptional();
            Property(x => x.tax_amnt).HasColumnName("tax_amnt").IsOptional();
            Property(x => x.refundable_reason_cause).HasColumnName("refundable_reason_cause").IsOptional().HasMaxLength(128);
            Property(x => x.refundable_amnt).HasColumnName("refundable_amnt").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_contact_address
    internal partial class hrm_t_contact_addressConfiguration : EntityTypeConfiguration<hrm_t_contact_address>
    {
        public hrm_t_contact_addressConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_contact_address");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.contact_address_name1).HasColumnName("contact_address_name1").IsOptional().HasMaxLength(128);
            Property(x => x.relationship_surety_div1).HasColumnName("relationship_surety_div1").IsOptional().HasMaxLength(20);
            Property(x => x.tel_no1).HasColumnName("tel_no1").IsOptional().HasMaxLength(64);
            Property(x => x.fax_no1).HasColumnName("fax_no1").IsOptional().HasMaxLength(64);
            Property(x => x.country_cd1).HasColumnName("country_cd1").IsOptional().HasMaxLength(20);
            Property(x => x.postcode1).HasColumnName("postcode1").IsOptional().HasMaxLength(20);
            Property(x => x.prefecture_name1).HasColumnName("prefecture_name1").IsOptional().HasMaxLength(64);
            Property(x => x.city_name1).HasColumnName("city_name1").IsOptional().HasMaxLength(64);
            Property(x => x.town_name1).HasColumnName("town_name1").IsOptional().HasMaxLength(255);
            Property(x => x.block_no_name1).HasColumnName("block_no_name1").IsOptional().HasMaxLength(64);
            Property(x => x.prefecture_name_kana1).HasColumnName("prefecture_name_kana1").IsOptional().HasMaxLength(64);
            Property(x => x.city_name_kana1).HasColumnName("city_name_kana1").IsOptional().HasMaxLength(64);
            Property(x => x.town_name_kana1).HasColumnName("town_name_kana1").IsOptional().HasMaxLength(255);
            Property(x => x.block_no_name_kana1).HasColumnName("block_no_name_kana1").IsOptional().HasMaxLength(64);
            Property(x => x.contact_address_name2).HasColumnName("contact_address_name2").IsOptional().HasMaxLength(128);
            Property(x => x.relationship_surety_div2).HasColumnName("relationship_surety_div2").IsOptional().HasMaxLength(20);
            Property(x => x.tel_no2).HasColumnName("tel_no2").IsOptional().HasMaxLength(64);
            Property(x => x.fax_no2).HasColumnName("fax_no2").IsOptional().HasMaxLength(64);
            Property(x => x.country_cd2).HasColumnName("country_cd2").IsOptional().HasMaxLength(20);
            Property(x => x.postcode2).HasColumnName("postcode2").IsOptional().HasMaxLength(20);
            Property(x => x.prefecture_name2).HasColumnName("prefecture_name2").IsOptional().HasMaxLength(64);
            Property(x => x.city_name2).HasColumnName("city_name2").IsOptional().HasMaxLength(64);
            Property(x => x.town_name2).HasColumnName("town_name2").IsOptional().HasMaxLength(255);
            Property(x => x.block_no_name2).HasColumnName("block_no_name2").IsOptional().HasMaxLength(64);
            Property(x => x.prefecture_name_kana2).HasColumnName("prefecture_name_kana2").IsOptional().HasMaxLength(64);
            Property(x => x.city_name_kana2).HasColumnName("city_name_kana2").IsOptional().HasMaxLength(64);
            Property(x => x.town_name_kana2).HasColumnName("town_name_kana2").IsOptional().HasMaxLength(255);
            Property(x => x.block_no_name_kana2).HasColumnName("block_no_name_kana2").IsOptional().HasMaxLength(64);
            Property(x => x.contact_address_name3).HasColumnName("contact_address_name3").IsOptional().HasMaxLength(128);
            Property(x => x.relationship_surety_div3).HasColumnName("relationship_surety_div3").IsOptional().HasMaxLength(20);
            Property(x => x.tel_no3).HasColumnName("tel_no3").IsOptional().HasMaxLength(64);
            Property(x => x.fax_no3).HasColumnName("fax_no3").IsOptional().HasMaxLength(64);
            Property(x => x.country_cd3).HasColumnName("country_cd3").IsOptional().HasMaxLength(20);
            Property(x => x.postcode3).HasColumnName("postcode3").IsOptional().HasMaxLength(20);
            Property(x => x.prefecture_name3).HasColumnName("prefecture_name3").IsOptional().HasMaxLength(64);
            Property(x => x.city_name3).HasColumnName("city_name3").IsOptional().HasMaxLength(64);
            Property(x => x.town_name3).HasColumnName("town_name3").IsOptional().HasMaxLength(255);
            Property(x => x.block_no_name3).HasColumnName("block_no_name3").IsOptional().HasMaxLength(64);
            Property(x => x.prefecture_name_kana3).HasColumnName("prefecture_name_kana3").IsOptional().HasMaxLength(64);
            Property(x => x.city_name_kana3).HasColumnName("city_name_kana3").IsOptional().HasMaxLength(64);
            Property(x => x.town_name_kana3).HasColumnName("town_name_kana3").IsOptional().HasMaxLength(255);
            Property(x => x.block_no_name_kana3).HasColumnName("block_no_name_kana3").IsOptional().HasMaxLength(64);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_dependent
    internal partial class hrm_t_dependentConfiguration : EntityTypeConfiguration<hrm_t_dependent>
    {
        public hrm_t_dependentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_dependent");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.self_general_dp_flg).HasColumnName("self_general_dp_flg").IsOptional();
            Property(x => x.self_special_dp_flg).HasColumnName("self_special_dp_flg").IsOptional();
            Property(x => x.partner_general_dp_flg).HasColumnName("partner_general_dp_flg").IsOptional();
            Property(x => x.partner_special_dp_flg).HasColumnName("partner_special_dp_flg").IsOptional();
            Property(x => x.partner_lt_special_dp_flg).HasColumnName("partner_lt_special_dp_flg").IsOptional();
            Property(x => x.dependent_general_dp_count).HasColumnName("dependent_general_dp_count").IsOptional();
            Property(x => x.dependent_special_dp_count).HasColumnName("dependent_special_dp_count").IsOptional();
            Property(x => x.dependent_lt_special_dp_count).HasColumnName("dependent_lt_special_dp_count").IsOptional();
            Property(x => x.widow_flg).HasColumnName("widow_flg").IsOptional();
            Property(x => x.special_widow_flg).HasColumnName("special_widow_flg").IsOptional();
            Property(x => x.widower_flg).HasColumnName("widower_flg").IsOptional();
            Property(x => x.working_student_flg).HasColumnName("working_student_flg").IsOptional();
            Property(x => x.dp_content_notes).HasColumnName("dp_content_notes").IsOptional().HasMaxLength(255);
            Property(x => x.relocation_date).HasColumnName("relocation_date").IsOptional();
            Property(x => x.relocation_cause).HasColumnName("relocation_cause").IsOptional().HasMaxLength(128);
            Property(x => x.inhabitant_tax_payment_name).HasColumnName("inhabitant_tax_payment_name").IsOptional().HasMaxLength(128);
            Property(x => x.tax_table_div).HasColumnName("tax_table_div").IsOptional().HasMaxLength(20);
            Property(x => x.self_annual_income_amnt).HasColumnName("self_annual_income_amnt").IsOptional();
            Property(x => x.partner_special_deduction_amnt).HasColumnName("partner_special_deduction_amnt").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_dependent_detail
    internal partial class hrm_t_dependent_detailConfiguration : EntityTypeConfiguration<hrm_t_dependent_detail>
    {
        public hrm_t_dependent_detailConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_dependent_detail");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.dependent_seq).HasColumnName("dependent_seq").IsRequired().HasMaxLength(20);
            Property(x => x.dependent_name).HasColumnName("dependent_name").IsOptional().HasMaxLength(128);
            Property(x => x.dependent_name_kana).HasColumnName("dependent_name_kana").IsOptional().HasMaxLength(128);
            Property(x => x.relationship_relative_div).HasColumnName("relationship_relative_div").IsOptional().HasMaxLength(20);
            Property(x => x.job_name).HasColumnName("job_name").IsOptional().HasMaxLength(128);
            Property(x => x.birth_date).HasColumnName("birth_date").IsOptional();
            Property(x => x.death_date).HasColumnName("death_date").IsOptional();
            Property(x => x.lt_aged_parent_flg).HasColumnName("lt_aged_parent_flg").IsOptional();
            Property(x => x.housing_country_cd).HasColumnName("housing_country_cd").IsOptional();
            Property(x => x.housing_postcode).HasColumnName("housing_postcode").IsOptional().HasMaxLength(20);
            Property(x => x.housing_prefecture_name).HasColumnName("housing_prefecture_name").IsOptional().HasMaxLength(64);
            Property(x => x.housing_city_name).HasColumnName("housing_city_name").IsOptional().HasMaxLength(64);
            Property(x => x.housing_town_name).HasColumnName("housing_town_name").IsOptional().HasMaxLength(255);
            Property(x => x.housing_block_no_name).HasColumnName("housing_block_no_name").IsOptional().HasMaxLength(64);
            Property(x => x.annual_income_amnt).HasColumnName("annual_income_amnt").IsOptional();
            Property(x => x.relocation_date).HasColumnName("relocation_date").IsOptional();
            Property(x => x.relocation_cause).HasColumnName("relocation_cause").IsOptional().HasMaxLength(128);
            Property(x => x.deduction_target_flg).HasColumnName("deduction_target_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_disabled
    internal partial class hrm_t_disabledConfiguration : EntityTypeConfiguration<hrm_t_disabled>
    {
        public hrm_t_disabledConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_disabled");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.disabled_status_flg).HasColumnName("disabled_status_flg").IsOptional();
            Property(x => x.dp_grade_div).HasColumnName("dp_grade_div").IsOptional().HasMaxLength(20);
            Property(x => x.dp_notebook_no).HasColumnName("dp_notebook_no").IsOptional().HasMaxLength(20);
            Property(x => x.dp_notebook_issue_date).HasColumnName("dp_notebook_issue_date").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_disaster
    internal partial class hrm_t_disasterConfiguration : EntityTypeConfiguration<hrm_t_disaster>
    {
        public hrm_t_disasterConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_disaster");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.disaster_seq).HasColumnName("disaster_seq").IsRequired().HasMaxLength(20);
            Property(x => x.disaster_accrual_date).HasColumnName("disaster_accrual_date").IsOptional();
            Property(x => x.disaster_class_div).HasColumnName("disaster_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.workmans_comp_aplct_status_flg).HasColumnName("workmans_comp_aplct_status_flg").IsOptional();
            Property(x => x.special_affair).HasColumnName("special_affair").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_duties_relocation
    internal partial class hrm_t_duties_relocationConfiguration : EntityTypeConfiguration<hrm_t_duties_relocation>
    {
        public hrm_t_duties_relocationConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_duties_relocation");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.duties_start_date).HasColumnName("duties_start_date").IsOptional();
            Property(x => x.duties_end_date).HasColumnName("duties_end_date").IsOptional();
            Property(x => x.company_cd).HasColumnName("company_cd").IsOptional();
            Property(x => x.duties_cd).HasColumnName("duties_cd").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_employee_base
    internal partial class hrm_t_employee_baseConfiguration : EntityTypeConfiguration<hrm_t_employee_base>
    {
        public hrm_t_employee_baseConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_employee_base");
            HasKey(x => x.employee_id);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.sex_div).HasColumnName("sex_div").IsOptional().HasMaxLength(20);
            Property(x => x.blood_type_div).HasColumnName("blood_type_div").IsOptional().HasMaxLength(20);
            Property(x => x.hometown_name).HasColumnName("hometown_name").IsOptional().HasMaxLength(128);
            Property(x => x.birth_date).HasColumnName("birth_date").IsOptional();
            Property(x => x.maiden_name).HasColumnName("maiden_name").IsOptional().HasMaxLength(128);
            Property(x => x.maiden_name_kana).HasColumnName("maiden_name_kana").IsOptional().HasMaxLength(128);
            Property(x => x.maiden_name_eng).HasColumnName("maiden_name_eng").IsOptional().HasMaxLength(128);
            Property(x => x.marriage_date).HasColumnName("marriage_date").IsOptional();
            Property(x => x.householder_flg).HasColumnName("householder_flg").IsOptional();
            Property(x => x.domi_country_cd).HasColumnName("domi_country_cd").IsOptional();
            Property(x => x.domi_postcode).HasColumnName("domi_postcode").IsOptional().HasMaxLength(20);
            Property(x => x.domi_prefecture_name).HasColumnName("domi_prefecture_name").IsOptional().HasMaxLength(64);
            Property(x => x.domi_city_name).HasColumnName("domi_city_name").IsOptional().HasMaxLength(64);
            Property(x => x.domi_town_name).HasColumnName("domi_town_name").IsOptional().HasMaxLength(255);
            Property(x => x.domi_block_no_name).HasColumnName("domi_block_no_name").IsOptional().HasMaxLength(64);
            Property(x => x.relationship_history_div).HasColumnName("relationship_history_div").IsOptional().HasMaxLength(20);
            Property(x => x.single_status_flg).HasColumnName("single_status_flg").IsOptional();
            Property(x => x.image_file_logical_name).HasColumnName("image_file_logical_name").IsOptional().HasMaxLength(128);
            Property(x => x.image_file_physical_name).HasColumnName("image_file_physical_name").IsOptional().HasMaxLength(128);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            Property(x => x.home_phone).HasColumnName("home_phone").IsOptional().HasMaxLength(20);
            Property(x => x.cell_phone).HasColumnName("cell_phone").IsOptional().HasMaxLength(20);
            Property(x => x.email).HasColumnName("email").IsOptional().HasMaxLength(128);
            Property(x => x.address).HasColumnName("address").IsOptional().HasMaxLength(512);
            Property(x => x.idcard_number).HasColumnName("idcard_number").IsOptional().HasMaxLength(20);
            Property(x => x.idcard_date).HasColumnName("idcard_date").IsOptional();
            Property(x => x.idcard_place).HasColumnName("idcard_place").IsOptional().HasMaxLength(128);
            Property(x => x.license_num).HasColumnName("license_num").IsOptional().HasMaxLength(128);
            Property(x => x.license_type).HasColumnName("license_type").IsOptional().HasMaxLength(64);
            Property(x => x.arg1).HasColumnName("arg1").IsOptional().HasMaxLength(255);
            Property(x => x.arg2).HasColumnName("arg2").IsOptional().HasMaxLength(255);
            Property(x => x.arg3).HasColumnName("arg3").IsOptional().HasMaxLength(255);
            Property(x => x.arg4).HasColumnName("arg4").IsOptional().HasMaxLength(255);
            Property(x => x.arg5).HasColumnName("arg5").IsOptional().HasMaxLength(255);
            Property(x => x.arg6).HasColumnName("arg6").IsOptional().HasMaxLength(255);
            Property(x => x.arg7).HasColumnName("arg7").IsOptional().HasMaxLength(255);
            Property(x => x.arg8).HasColumnName("arg8").IsOptional().HasMaxLength(255);
            Property(x => x.arg9).HasColumnName("arg9").IsOptional().HasMaxLength(255);
            Property(x => x.arg10).HasColumnName("arg10").IsOptional().HasMaxLength(255);
            Property(x => x.employee_id).HasColumnName("employee_id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_employee_other
    internal partial class hrm_t_employee_otherConfiguration : EntityTypeConfiguration<hrm_t_employee_other>
    {
        public hrm_t_employee_otherConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_employee_other");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.passport_no).HasColumnName("passport_no").IsOptional().HasMaxLength(20);
            Property(x => x.passport_time_limit_date).HasColumnName("passport_time_limit_date").IsOptional();
            Property(x => x.country_cd).HasColumnName("country_cd").IsOptional();
            Property(x => x.extension_tel_no).HasColumnName("extension_tel_no").IsOptional().HasMaxLength(64);
            Property(x => x.extension_fax_no).HasColumnName("extension_fax_no").IsOptional().HasMaxLength(64);
            Property(x => x.mobile_tel_no1).HasColumnName("mobile_tel_no1").IsOptional().HasMaxLength(64);
            Property(x => x.mobile_tel_no2).HasColumnName("mobile_tel_no2").IsOptional().HasMaxLength(64);
            Property(x => x.mobile_mail_address1).HasColumnName("mobile_mail_address1").IsOptional().HasMaxLength(128);
            Property(x => x.mobile_mail_address2).HasColumnName("mobile_mail_address2").IsOptional().HasMaxLength(128);
            Property(x => x.mail_address1).HasColumnName("mail_address1").IsOptional().HasMaxLength(128);
            Property(x => x.mail_address2).HasColumnName("mail_address2").IsOptional().HasMaxLength(128);
            Property(x => x.url).HasColumnName("url").IsOptional().HasMaxLength(128);
            Property(x => x.hobby1).HasColumnName("hobby1").IsOptional().HasMaxLength(64);
            Property(x => x.hobby2).HasColumnName("hobby2").IsOptional().HasMaxLength(64);
            Property(x => x.special_skill1).HasColumnName("special_skill1").IsOptional().HasMaxLength(64);
            Property(x => x.special_skill2).HasColumnName("special_skill2").IsOptional().HasMaxLength(64);
            Property(x => x.language_study_name).HasColumnName("language_study_name").IsOptional().HasMaxLength(128);
            Property(x => x.holdings_company_stock).HasColumnName("holdings_company_stock").IsOptional().HasMaxLength(20);
            Property(x => x.personal_stock).HasColumnName("personal_stock").IsOptional().HasMaxLength(20);
            Property(x => x.special_affair1).HasColumnName("special_affair1").IsOptional().HasMaxLength(255);
            Property(x => x.special_affair2).HasColumnName("special_affair2").IsOptional().HasMaxLength(255);
            Property(x => x.special_affair3).HasColumnName("special_affair3").IsOptional().HasMaxLength(255);
            Property(x => x.special_affair4).HasColumnName("special_affair4").IsOptional().HasMaxLength(255);
            Property(x => x.joining_company_rated_age).HasColumnName("joining_company_rated_age").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_former_job
    internal partial class hrm_t_former_jobConfiguration : EntityTypeConfiguration<hrm_t_former_job>
    {
        public hrm_t_former_jobConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_former_job");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.former_job_seq).HasColumnName("former_job_seq").IsRequired().HasMaxLength(20);
            Property(x => x.company_name).HasColumnName("company_name").IsOptional().HasMaxLength(128);
            Property(x => x.joining_company_date).HasColumnName("joining_company_date").IsOptional();
            Property(x => x.retire_date).HasColumnName("retire_date").IsOptional();
            Property(x => x.industry_name).HasColumnName("industry_name").IsOptional().HasMaxLength(128);
            Property(x => x.post_name).HasColumnName("post_name").IsOptional().HasMaxLength(128);
            Property(x => x.branch_name).HasColumnName("branch_name").IsOptional().HasMaxLength(128);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_health_checkup
    internal partial class hrm_t_health_checkupConfiguration : EntityTypeConfiguration<hrm_t_health_checkup>
    {
        public hrm_t_health_checkupConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_health_checkup");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.health_checkup_seq).HasColumnName("health_checkup_seq").IsRequired().HasMaxLength(20);
            Property(x => x.health_checkup_date).HasColumnName("health_checkup_date").IsOptional();
            Property(x => x.health_checkup_place_name).HasColumnName("health_checkup_place_name").IsOptional().HasMaxLength(128);
            Property(x => x.body_height_hc).HasColumnName("body_height_hc").IsOptional().HasMaxLength(10);
            Property(x => x.body_weight_hc).HasColumnName("body_weight_hc").IsOptional().HasMaxLength(10);
            Property(x => x.vision_left_hc).HasColumnName("vision_left_hc").IsOptional().HasMaxLength(10);
            Property(x => x.vision_right_hc).HasColumnName("vision_right_hc").IsOptional().HasMaxLength(10);
            Property(x => x.correction_vision_left_hc).HasColumnName("correction_vision_left_hc").IsOptional().HasMaxLength(10);
            Property(x => x.correction_vision_right_hc).HasColumnName("correction_vision_right_hc").IsOptional().HasMaxLength(10);
            Property(x => x.color_blind_hc).HasColumnName("color_blind_hc").IsOptional().HasMaxLength(10);
            Property(x => x.hearing_left_hc).HasColumnName("hearing_left_hc").IsOptional().HasMaxLength(10);
            Property(x => x.hearing_right_hc).HasColumnName("hearing_right_hc").IsOptional().HasMaxLength(10);
            Property(x => x.blood_pressure_up_hc).HasColumnName("blood_pressure_up_hc").IsOptional().HasMaxLength(10);
            Property(x => x.blood_pressure_down_hc).HasColumnName("blood_pressure_down_hc").IsOptional().HasMaxLength(10);
            Property(x => x.chest_radiography_hc).HasColumnName("chest_radiography_hc").IsOptional().HasMaxLength(10);
            Property(x => x.electrocardiogram_hc).HasColumnName("electrocardiogram_hc").IsOptional().HasMaxLength(10);
            Property(x => x.urine_check_sugar_hc).HasColumnName("urine_check_sugar_hc").IsOptional().HasMaxLength(10);
            Property(x => x.urine_check_protein_hc).HasColumnName("urine_check_protein_hc").IsOptional().HasMaxLength(10);
            Property(x => x.urine_hidden_blood_hc).HasColumnName("urine_hidden_blood_hc").IsOptional().HasMaxLength(10);
            Property(x => x.blood_check_blood_pigment_hc).HasColumnName("blood_check_blood_pigment_hc").IsOptional().HasMaxLength(10);
            Property(x => x.blood_check_blood_rbc_amnt_hc).HasColumnName("blood_check_blood_rbc_amnt_hc").IsOptional().HasMaxLength(10);
            Property(x => x.blood_check_got_hc).HasColumnName("blood_check_got_hc").IsOptional().HasMaxLength(10);
            Property(x => x.blood_check_gpt_hc).HasColumnName("blood_check_gpt_hc").IsOptional().HasMaxLength(10);
            Property(x => x.blood_check_gtp_hc).HasColumnName("blood_check_gtp_hc").IsOptional().HasMaxLength(10);
            Property(x => x.blood_check_cholesterol_hc).HasColumnName("blood_check_cholesterol_hc").IsOptional().HasMaxLength(10);
            Property(x => x.blood_check_neutral_fat_hc).HasColumnName("blood_check_neutral_fat_hc").IsOptional().HasMaxLength(10);
            Property(x => x.health_interview_notes).HasColumnName("health_interview_notes").IsOptional().HasMaxLength(255);
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_joining_company
    internal partial class hrm_t_joining_companyConfiguration : EntityTypeConfiguration<hrm_t_joining_company>
    {
        public hrm_t_joining_companyConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_joining_company");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.joining_company_date).HasColumnName("joining_company_date").IsOptional();
            Property(x => x.recruitment_class_div).HasColumnName("recruitment_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.recruitment_area_name).HasColumnName("recruitment_area_name").IsOptional().HasMaxLength(128);
            Property(x => x.introduction_user_name).HasColumnName("introduction_user_name").IsOptional().HasMaxLength(128);
            Property(x => x.relationship_introduction_div).HasColumnName("relationship_introduction_div").IsOptional().HasMaxLength(20);
            Property(x => x.contract_start_date).HasColumnName("contract_start_date").IsOptional();
            Property(x => x.contract_end_date).HasColumnName("contract_end_date").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_joining_contract
    internal partial class hrm_t_joining_contractConfiguration : EntityTypeConfiguration<hrm_t_joining_contract>
    {
        public hrm_t_joining_contractConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_joining_contract");
            HasKey(x => new { x.employee_cd, x.contract_cd });

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.contract_cd).HasColumnName("contract_cd").IsRequired();
            Property(x => x.contract_start_date).HasColumnName("contract_start_date").IsOptional();
            Property(x => x.contract_end_date).HasColumnName("contract_end_date").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_oa_grade_relocation
    internal partial class hrm_t_oa_grade_relocationConfiguration : EntityTypeConfiguration<hrm_t_oa_grade_relocation>
    {
        public hrm_t_oa_grade_relocationConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_oa_grade_relocation");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.oa_grade_start_date).HasColumnName("oa_grade_start_date").IsOptional();
            Property(x => x.oa_grade_end_date).HasColumnName("oa_grade_end_date").IsOptional();
            Property(x => x.company_cd).HasColumnName("company_cd").IsOptional();
            Property(x => x.oa_grade_cd).HasColumnName("oa_grade_cd").IsOptional();
            Property(x => x.oa_grade_raise_div).HasColumnName("oa_grade_raise_div").IsOptional().HasMaxLength(20);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            Property(x => x.seniority_cd).HasColumnName("seniority_cd").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_oa_qualf_relocation
    internal partial class hrm_t_oa_qualf_relocationConfiguration : EntityTypeConfiguration<hrm_t_oa_qualf_relocation>
    {
        public hrm_t_oa_qualf_relocationConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_oa_qualf_relocation");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.oa_qualf_start_date).HasColumnName("oa_qualf_start_date").IsOptional();
            Property(x => x.oa_qualf_end_date).HasColumnName("oa_qualf_end_date").IsOptional();
            Property(x => x.company_cd).HasColumnName("company_cd").IsOptional();
            Property(x => x.oa_qualf_cd).HasColumnName("oa_qualf_cd").IsOptional();
            Property(x => x.oa_qualf_raise_div).HasColumnName("oa_qualf_raise_div").IsOptional().HasMaxLength(20);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_old_school
    internal partial class hrm_t_old_schoolConfiguration : EntityTypeConfiguration<hrm_t_old_school>
    {
        public hrm_t_old_schoolConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_old_school");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.old_school_seq).HasColumnName("old_school_seq").IsRequired().HasMaxLength(20);
            Property(x => x.school_name).HasColumnName("school_name").IsOptional().HasMaxLength(128);
            Property(x => x.faculty_name).HasColumnName("faculty_name").IsOptional().HasMaxLength(128);
            Property(x => x.subject_name).HasColumnName("subject_name").IsOptional().HasMaxLength(128);
            Property(x => x.laboratory_name).HasColumnName("laboratory_name").IsOptional().HasMaxLength(128);
            Property(x => x.school_class_div).HasColumnName("school_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.entrance_date).HasColumnName("entrance_date").IsOptional();
            Property(x => x.graduation_date).HasColumnName("graduation_date").IsOptional();
            Property(x => x.graduation_status_div).HasColumnName("graduation_status_div").IsOptional().HasMaxLength(20);
            Property(x => x.course_class_div).HasColumnName("course_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.day_evening_class_div).HasColumnName("day_evening_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_payment
    internal partial class hrm_t_paymentConfiguration : EntityTypeConfiguration<hrm_t_payment>
    {
        public hrm_t_paymentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_payment");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.payment_recipient_div1).HasColumnName("payment_recipient_div1").IsOptional().HasMaxLength(20);
            Property(x => x.bank_cd1).HasColumnName("bank_cd1").IsOptional().HasMaxLength(20);
            Property(x => x.deposit_item_div1).HasColumnName("deposit_item_div1").IsOptional().HasMaxLength(20);
            Property(x => x.account_no1).HasColumnName("account_no1").IsOptional().HasMaxLength(20);
            Property(x => x.bank_account_name1).HasColumnName("bank_account_name1").IsOptional().HasMaxLength(128);
            Property(x => x.po_name1).HasColumnName("po_name1").IsOptional().HasMaxLength(128);
            Property(x => x.deposit_sign1).HasColumnName("deposit_sign1").IsOptional().HasMaxLength(20);
            Property(x => x.deposit_no1).HasColumnName("deposit_no1").IsOptional().HasMaxLength(20);
            Property(x => x.po_account_name1).HasColumnName("po_account_name1").IsOptional().HasMaxLength(128);
            Property(x => x.salary_transfer_fixed_amnt1).HasColumnName("salary_transfer_fixed_amnt1").IsOptional();
            Property(x => x.bonus_transfer_fixed_amnt1).HasColumnName("bonus_transfer_fixed_amnt1").IsOptional();
            Property(x => x.payment_recipient_div2).HasColumnName("payment_recipient_div2").IsOptional().HasMaxLength(20);
            Property(x => x.bank_cd2).HasColumnName("bank_cd2").IsOptional().HasMaxLength(20);
            Property(x => x.deposit_item_div2).HasColumnName("deposit_item_div2").IsOptional().HasMaxLength(20);
            Property(x => x.account_no2).HasColumnName("account_no2").IsOptional().HasMaxLength(20);
            Property(x => x.bank_account_name2).HasColumnName("bank_account_name2").IsOptional().HasMaxLength(128);
            Property(x => x.po_name2).HasColumnName("po_name2").IsOptional().HasMaxLength(128);
            Property(x => x.deposit_sign2).HasColumnName("deposit_sign2").IsOptional().HasMaxLength(20);
            Property(x => x.deposit_no2).HasColumnName("deposit_no2").IsOptional().HasMaxLength(20);
            Property(x => x.po_account_name2).HasColumnName("po_account_name2").IsOptional().HasMaxLength(128);
            Property(x => x.salary_transfer_fixed_amnt2).HasColumnName("salary_transfer_fixed_amnt2").IsOptional();
            Property(x => x.bonus_transfer_fixed_amnt2).HasColumnName("bonus_transfer_fixed_amnt2").IsOptional();
            Property(x => x.payment_recipient_div3).HasColumnName("payment_recipient_div3").IsOptional().HasMaxLength(20);
            Property(x => x.bank_cd3).HasColumnName("bank_cd3").IsOptional().HasMaxLength(20);
            Property(x => x.deposit_item_div3).HasColumnName("deposit_item_div3").IsOptional().HasMaxLength(20);
            Property(x => x.account_no3).HasColumnName("account_no3").IsOptional().HasMaxLength(20);
            Property(x => x.bank_account_name3).HasColumnName("bank_account_name3").IsOptional().HasMaxLength(128);
            Property(x => x.po_name3).HasColumnName("po_name3").IsOptional().HasMaxLength(128);
            Property(x => x.deposit_sign3).HasColumnName("deposit_sign3").IsOptional().HasMaxLength(20);
            Property(x => x.deposit_no3).HasColumnName("deposit_no3").IsOptional().HasMaxLength(20);
            Property(x => x.po_account_name3).HasColumnName("po_account_name3").IsOptional().HasMaxLength(128);
            Property(x => x.payment_recipient_target_div4).HasColumnName("payment_recipient_target_div4").IsOptional().HasMaxLength(20);
            Property(x => x.payment_recipient_div4).HasColumnName("payment_recipient_div4").IsOptional().HasMaxLength(20);
            Property(x => x.bank_cd4).HasColumnName("bank_cd4").IsOptional().HasMaxLength(20);
            Property(x => x.deposit_item_div4).HasColumnName("deposit_item_div4").IsOptional().HasMaxLength(20);
            Property(x => x.account_no4).HasColumnName("account_no4").IsOptional().HasMaxLength(20);
            Property(x => x.bank_account_name4).HasColumnName("bank_account_name4").IsOptional().HasMaxLength(128);
            Property(x => x.po_name4).HasColumnName("po_name4").IsOptional().HasMaxLength(128);
            Property(x => x.deposit_sign4).HasColumnName("deposit_sign4").IsOptional().HasMaxLength(20);
            Property(x => x.deposit_no4).HasColumnName("deposit_no4").IsOptional().HasMaxLength(20);
            Property(x => x.po_account_name4).HasColumnName("po_account_name4").IsOptional().HasMaxLength(128);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_present_address
    internal partial class hrm_t_present_addressConfiguration : EntityTypeConfiguration<hrm_t_present_address>
    {
        public hrm_t_present_addressConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_present_address");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.start_date).HasColumnName("start_date").IsOptional();
            Property(x => x.end_date).HasColumnName("end_date").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_present_address_detail
    internal partial class hrm_t_present_address_detailConfiguration : EntityTypeConfiguration<hrm_t_present_address_detail>
    {
        public hrm_t_present_address_detailConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_present_address_detail");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.housing_class_div).HasColumnName("housing_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.housing_status_div).HasColumnName("housing_status_div").IsOptional().HasMaxLength(20);
            Property(x => x.country_cd).HasColumnName("country_cd").IsOptional();
            Property(x => x.postcode).HasColumnName("postcode").IsOptional().HasMaxLength(20);
            Property(x => x.prefecture_name).HasColumnName("prefecture_name").IsOptional().HasMaxLength(64);
            Property(x => x.city_name).HasColumnName("city_name").IsOptional().HasMaxLength(64);
            Property(x => x.town_name).HasColumnName("town_name").IsOptional().HasMaxLength(255);
            Property(x => x.block_no_name).HasColumnName("block_no_name").IsOptional().HasMaxLength(64);
            Property(x => x.prefecture_name_kana).HasColumnName("prefecture_name_kana").IsOptional().HasMaxLength(64);
            Property(x => x.city_name_kana).HasColumnName("city_name_kana").IsOptional().HasMaxLength(64);
            Property(x => x.town_name_kana).HasColumnName("town_name_kana").IsOptional().HasMaxLength(255);
            Property(x => x.block_no_name_kana).HasColumnName("block_no_name_kana").IsOptional().HasMaxLength(64);
            Property(x => x.tel_no).HasColumnName("tel_no").IsOptional().HasMaxLength(64);
            Property(x => x.fax_no).HasColumnName("fax_no").IsOptional().HasMaxLength(64);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_previous_illness
    internal partial class hrm_t_previous_illnessConfiguration : EntityTypeConfiguration<hrm_t_previous_illness>
    {
        public hrm_t_previous_illnessConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_previous_illness");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.previous_illness_seq).HasColumnName("previous_illness_seq").IsRequired().HasMaxLength(20);
            Property(x => x.previous_illness_name).HasColumnName("previous_illness_name").IsOptional().HasMaxLength(128);
            Property(x => x.previous_illness_attack_date).HasColumnName("previous_illness_attack_date").IsOptional();
            Property(x => x.previous_illness_cure_date).HasColumnName("previous_illness_cure_date").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_qualf
    internal partial class hrm_t_qualfConfiguration : EntityTypeConfiguration<hrm_t_qualf>
    {
        public hrm_t_qualfConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_qualf");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.qualf_seq).HasColumnName("qualf_seq").IsRequired().HasMaxLength(20);
            Property(x => x.qualf_group_cd).HasColumnName("qualf_group_cd").IsOptional();
            Property(x => x.qualf_cd).HasColumnName("qualf_cd").IsOptional();
            Property(x => x.qualf_take_date).HasColumnName("qualf_take_date").IsOptional();
            Property(x => x.qualf_update_date).HasColumnName("qualf_update_date").IsOptional();
            Property(x => x.qualf_valid_time_limit_date).HasColumnName("qualf_valid_time_limit_date").IsOptional();
            Property(x => x.qualf_certification_no_name).HasColumnName("qualf_certification_no_name").IsOptional().HasMaxLength(128);
            Property(x => x.qualf_allowance_flg).HasColumnName("qualf_allowance_flg").IsOptional();
            Property(x => x.special_affair).HasColumnName("special_affair").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_retire
    internal partial class hrm_t_retireConfiguration : EntityTypeConfiguration<hrm_t_retire>
    {
        public hrm_t_retireConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_retire");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.retire_date).HasColumnName("retire_date").IsOptional();
            Property(x => x.retire_cause).HasColumnName("retire_cause").IsOptional().HasMaxLength(128);
            Property(x => x.sevp_amnt).HasColumnName("sevp_amnt").IsOptional();
            Property(x => x.retire_point_count).HasColumnName("retire_point_count").IsOptional();
            Property(x => x.ob_society_join_status_flg).HasColumnName("ob_society_join_status_flg").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_social_labor_insurance
    internal partial class hrm_t_social_labor_insuranceConfiguration : EntityTypeConfiguration<hrm_t_social_labor_insurance>
    {
        public hrm_t_social_labor_insuranceConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_social_labor_insurance");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.ntnl_pnsn_base_no).HasColumnName("ntnl_pnsn_base_no").IsOptional().HasMaxLength(20);
            Property(x => x.ntnl_pnsn_base_take_date).HasColumnName("ntnl_pnsn_base_take_date").IsOptional();
            Property(x => x.ntnl_pnsn_base_loss_date).HasColumnName("ntnl_pnsn_base_loss_date").IsOptional();
            Property(x => x.hi_card_no).HasColumnName("hi_card_no").IsOptional().HasMaxLength(20);
            Property(x => x.erenow_hi_standard_rmnrt_amnt).HasColumnName("erenow_hi_standard_rmnrt_amnt").IsOptional();
            Property(x => x.hi_take_date).HasColumnName("hi_take_date").IsOptional();
            Property(x => x.hi_loss_date).HasColumnName("hi_loss_date").IsOptional();
            Property(x => x.empm_insurance_join_status_div).HasColumnName("empm_insurance_join_status_div").IsOptional().HasMaxLength(20);
            Property(x => x.empm_insurance_card_no).HasColumnName("empm_insurance_card_no").IsOptional().HasMaxLength(20);
            Property(x => x.short_time_insured_person_flg).HasColumnName("short_time_insured_person_flg").IsOptional();
            Property(x => x.empm_insurance_take_date).HasColumnName("empm_insurance_take_date").IsOptional();
            Property(x => x.empm_insurance_loss_date).HasColumnName("empm_insurance_loss_date").IsOptional();
            Property(x => x.workmans_comp_join_user_flg).HasColumnName("workmans_comp_join_user_flg").IsOptional();
            Property(x => x.basic_pension_sign).HasColumnName("basic_pension_sign").IsOptional().HasMaxLength(20);
            Property(x => x.basic_pension_notebook_no).HasColumnName("basic_pension_notebook_no").IsOptional().HasMaxLength(20);
            Property(x => x.basic_pension_serial_no).HasColumnName("basic_pension_serial_no").IsOptional().HasMaxLength(20);
            Property(x => x.erenow_standard_rmnrt_amnt).HasColumnName("erenow_standard_rmnrt_amnt").IsOptional();
            Property(x => x.basic_pension_join_user_flg).HasColumnName("basic_pension_join_user_flg").IsOptional();
            Property(x => x.basic_pension_take_date).HasColumnName("basic_pension_take_date").IsOptional();
            Property(x => x.basic_pension_loss_date).HasColumnName("basic_pension_loss_date").IsOptional();
            Property(x => x.empl_pension_fund_join_user_no).HasColumnName("empl_pension_fund_join_user_no").IsOptional().HasMaxLength(20);
            Property(x => x.empl_pension_fund_serial_no).HasColumnName("empl_pension_fund_serial_no").IsOptional().HasMaxLength(20);
            Property(x => x.empl_pension_basic_salary_amnt).HasColumnName("empl_pension_basic_salary_amnt").IsOptional();
            Property(x => x.empl_pension_first_add_flg).HasColumnName("empl_pension_first_add_flg").IsOptional();
            Property(x => x.empl_pension_second_add_flg).HasColumnName("empl_pension_second_add_flg").IsOptional();
            Property(x => x.empl_pension_take_date).HasColumnName("empl_pension_take_date").IsOptional();
            Property(x => x.empl_pension_loss_date).HasColumnName("empl_pension_loss_date").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_surety_detail
    internal partial class hrm_t_surety_detailConfiguration : EntityTypeConfiguration<hrm_t_surety_detail>
    {
        public hrm_t_surety_detailConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_surety_detail");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.surety_name).HasColumnName("surety_name").IsOptional().HasMaxLength(128);
            Property(x => x.relationship_surety_div).HasColumnName("relationship_surety_div").IsOptional().HasMaxLength(20);
            Property(x => x.tel_no).HasColumnName("tel_no").IsOptional().HasMaxLength(64);
            Property(x => x.domi_country_cd).HasColumnName("domi_country_cd").IsOptional();
            Property(x => x.domi_postcode).HasColumnName("domi_postcode").IsOptional().HasMaxLength(20);
            Property(x => x.domi_prefecture_name).HasColumnName("domi_prefecture_name").IsOptional().HasMaxLength(64);
            Property(x => x.domi_city_name).HasColumnName("domi_city_name").IsOptional().HasMaxLength(64);
            Property(x => x.domi_town_name).HasColumnName("domi_town_name").IsOptional().HasMaxLength(255);
            Property(x => x.domi_block_no_name).HasColumnName("domi_block_no_name").IsOptional().HasMaxLength(64);
            Property(x => x.address_country_cd).HasColumnName("address_country_cd").IsOptional();
            Property(x => x.address_postcode).HasColumnName("address_postcode").IsOptional().HasMaxLength(20);
            Property(x => x.address_prefecture_name).HasColumnName("address_prefecture_name").IsOptional().HasMaxLength(64);
            Property(x => x.address_city_name).HasColumnName("address_city_name").IsOptional().HasMaxLength(64);
            Property(x => x.address_town_name).HasColumnName("address_town_name").IsOptional().HasMaxLength(255);
            Property(x => x.address_block_no_name).HasColumnName("address_block_no_name").IsOptional().HasMaxLength(64);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_temporary_transfer
    internal partial class hrm_t_temporary_transferConfiguration : EntityTypeConfiguration<hrm_t_temporary_transfer>
    {
        public hrm_t_temporary_transferConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_temporary_transfer");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.term_cd).HasColumnName("term_cd").IsOptional();
            Property(x => x.temporary_transfer_start_date).HasColumnName("temporary_transfer_start_date").IsOptional();
            Property(x => x.temporary_transfer_end_date).HasColumnName("temporary_transfer_end_date").IsOptional();
            Property(x => x.temporary_transfer_class_div).HasColumnName("temporary_transfer_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.company_name).HasColumnName("company_name").IsOptional().HasMaxLength(128);
            Property(x => x.department_name).HasColumnName("department_name").IsOptional().HasMaxLength(128);
            Property(x => x.post_name).HasColumnName("post_name").IsOptional().HasMaxLength(128);
            Property(x => x.tel_no).HasColumnName("tel_no").IsOptional().HasMaxLength(64);
            Property(x => x.work_name).HasColumnName("work_name").IsOptional().HasMaxLength(128);
            Property(x => x.address_country_cd).HasColumnName("address_country_cd").IsOptional();
            Property(x => x.address_postcode).HasColumnName("address_postcode").IsOptional().HasMaxLength(20);
            Property(x => x.address_prefecture_name).HasColumnName("address_prefecture_name").IsOptional().HasMaxLength(64);
            Property(x => x.address_city_name).HasColumnName("address_city_name").IsOptional().HasMaxLength(64);
            Property(x => x.address_town_name).HasColumnName("address_town_name").IsOptional().HasMaxLength(255);
            Property(x => x.address_block_no_name).HasColumnName("address_block_no_name").IsOptional().HasMaxLength(64);
            Property(x => x.address_prefecture_name_kana).HasColumnName("address_prefecture_name_kana").IsOptional().HasMaxLength(64);
            Property(x => x.address_city_name_kana).HasColumnName("address_city_name_kana").IsOptional().HasMaxLength(64);
            Property(x => x.address_town_name_kana).HasColumnName("address_town_name_kana").IsOptional().HasMaxLength(255);
            Property(x => x.address_block_no_name_kana).HasColumnName("address_block_no_name_kana").IsOptional().HasMaxLength(64);
            Property(x => x.abroad_work_status_flg).HasColumnName("abroad_work_status_flg").IsOptional();
            Property(x => x.visa_time_limit_date).HasColumnName("visa_time_limit_date").IsOptional();
            Property(x => x.go_alone_status_flg).HasColumnName("go_alone_status_flg").IsOptional();
            Property(x => x.relocation_content_notes).HasColumnName("relocation_content_notes").IsOptional().HasMaxLength(255);
            Property(x => x.rel_relocation_content_notes).HasColumnName("rel_relocation_content_notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_treatment
    internal partial class hrm_t_treatmentConfiguration : EntityTypeConfiguration<hrm_t_treatment>
    {
        public hrm_t_treatmentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_treatment");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.company_cd).HasColumnName("company_cd").IsOptional();
            Property(x => x.work_place_cd).HasColumnName("work_place_cd").IsOptional();
            Property(x => x.work_system_cd).HasColumnName("work_system_cd").IsOptional();
            Property(x => x.empm_class_div).HasColumnName("empm_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.salary_class_div).HasColumnName("salary_class_div").IsOptional().HasMaxLength(20);
            Property(x => x.abroad_work_status_flg).HasColumnName("abroad_work_status_flg").IsOptional();
            Property(x => x.station_name).HasColumnName("station_name").IsOptional().HasMaxLength(128);
            Property(x => x.station_start_date).HasColumnName("station_start_date").IsOptional();
            Property(x => x.station_end_date).HasColumnName("station_end_date").IsOptional();
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            Property(x => x.grade_level).HasColumnName("grade_level").IsOptional().HasMaxLength(20);
            Property(x => x.seniority_level).HasColumnName("seniority_level").IsOptional().HasMaxLength(20);
            Property(x => x.school_class_div).HasColumnName("school_class_div").IsOptional().HasMaxLength(20);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_union_executive
    internal partial class hrm_t_union_executiveConfiguration : EntityTypeConfiguration<hrm_t_union_executive>
    {
        public hrm_t_union_executiveConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_union_executive");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.union_executive_seq).HasColumnName("union_executive_seq").IsRequired().HasMaxLength(20);
            Property(x => x.union_executive_name).HasColumnName("union_executive_name").IsOptional().HasMaxLength(128);
            Property(x => x.union_executive_start_date).HasColumnName("union_executive_start_date").IsOptional();
            Property(x => x.union_executive_end_date).HasColumnName("union_executive_end_date").IsOptional();
            Property(x => x.full_time_flg).HasColumnName("full_time_flg").IsOptional();
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // hrm_t_union_join
    internal partial class hrm_t_union_joinConfiguration : EntityTypeConfiguration<hrm_t_union_join>
    {
        public hrm_t_union_joinConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".hrm_t_union_join");
            HasKey(x => x.employee_cd);

            Property(x => x.employee_cd).HasColumnName("employee_cd").IsRequired();
            Property(x => x.union_join_seq).HasColumnName("union_join_seq").IsRequired().HasMaxLength(20);
            Property(x => x.company_cd).HasColumnName("company_cd").IsOptional();
            Property(x => x.union_cd).HasColumnName("union_cd").IsOptional();
            Property(x => x.union_start_date).HasColumnName("union_start_date").IsOptional();
            Property(x => x.union_end_date).HasColumnName("union_end_date").IsOptional();
            Property(x => x.notes).HasColumnName("notes").IsOptional().HasMaxLength(255);
            Property(x => x.record_user_cd).HasColumnName("record_user_cd").IsOptional();
            Property(x => x.record_date).HasColumnName("record_date").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Location
    internal partial class LocationConfiguration : EntityTypeConfiguration<Location>
    {
        public LocationConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Location");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(500);
            Property(x => x.Code).HasColumnName("Code").IsRequired().HasMaxLength(50);
            Property(x => x.FullCode).HasColumnName("FullCode").IsOptional().HasMaxLength(20);
            Property(x => x.ProjectId).HasColumnName("ProjectId").IsRequired();
            Property(x => x.LocationParent).HasColumnName("LocationParent").IsOptional();
            Property(x => x.Level).HasColumnName("Level").IsOptional();

            // Foreign keys
            HasRequired(a => a.Project).WithMany(b => b.Location).HasForeignKey(c => c.ProjectId); // FK_Location_Project
            HasOptional(a => a.Location1).WithMany(b => b.Location2).HasForeignKey(c => c.LocationParent); // FK_Location_Location
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Permissions
    internal partial class PermissionsConfiguration : EntityTypeConfiguration<Permissions>
    {
        public PermissionsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Permissions");
            HasKey(x => x.PermissionId);

            Property(x => x.PermissionId).HasColumnName("PermissionId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProjectRoleId).HasColumnName("ProjectRoleId").IsOptional();
            Property(x => x.FunctionId).HasColumnName("FunctionId").IsOptional();

            // Foreign keys
            HasOptional(a => a.ProjectRole).WithMany(b => b.Permissions).HasForeignKey(c => c.ProjectRoleId); // FK_Permissions_ProjectRole
            HasOptional(a => a.Function).WithMany(b => b.Permissions).HasForeignKey(c => c.FunctionId); // FK_Permissions_Function
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Project
    internal partial class ProjectConfiguration : EntityTypeConfiguration<Project>
    {
        public ProjectConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Project");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);
            Property(x => x.Description).HasColumnName("Description").IsOptional().HasMaxLength(100);
            Property(x => x.ShortName).HasColumnName("ShortName").IsOptional().HasMaxLength(50);
            Property(x => x.FullCode).HasColumnName("FullCode").IsOptional().HasMaxLength(20);
            Property(x => x.CountryId).HasColumnName("CountryId").IsRequired();
            Property(x => x.TimeZone).HasColumnName("TimeZone").IsOptional();

            // Foreign keys
            HasRequired(a => a.Country).WithMany(b => b.Project).HasForeignKey(c => c.CountryId); // FK_Project_Country
            HasOptional(a => a.TimeZone_TimeZone).WithMany(b => b.Project).HasForeignKey(c => c.TimeZone); // FK_Project_TimeZone
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // ProjectPermissions
    internal partial class ProjectPermissionsConfiguration : EntityTypeConfiguration<ProjectPermissions>
    {
        public ProjectPermissionsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ProjectPermissions");
            HasKey(x => x.ProjectPermissionId);

            Property(x => x.ProjectPermissionId).HasColumnName("ProjectPermissionId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PermissionId).HasColumnName("PermissionId").IsOptional();
            Property(x => x.ProjectUserId).HasColumnName("ProjectUserId").IsOptional();

            // Foreign keys
            HasOptional(a => a.Permissions).WithMany(b => b.ProjectPermissions).HasForeignKey(c => c.PermissionId); // FK_ProjectPermissions_Permissions
            HasOptional(a => a.ProjectUser).WithMany(b => b.ProjectPermissions).HasForeignKey(c => c.ProjectUserId); // FK_ProjectPermissions_ProjectUser
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // ProjectRole
    internal partial class ProjectRoleConfiguration : EntityTypeConfiguration<ProjectRole>
    {
        public ProjectRoleConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ProjectRole");
            HasKey(x => x.ProjectRoleId);

            Property(x => x.ProjectRoleId).HasColumnName("ProjectRoleId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsOptional().HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // ProjectUser
    internal partial class ProjectUserConfiguration : EntityTypeConfiguration<ProjectUser>
    {
        public ProjectUserConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".ProjectUser");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProjectId).HasColumnName("ProjectId").IsRequired();
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();

            // Foreign keys
            HasRequired(a => a.Project).WithMany(b => b.ProjectUser).HasForeignKey(c => c.ProjectId); // FK_ProjectUser_Project
            HasRequired(a => a.UserProfile).WithMany(b => b.ProjectUser).HasForeignKey(c => c.UserId); // FK_ProjectUser_UserProfile
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Region
    internal partial class RegionConfiguration : EntityTypeConfiguration<Region>
    {
        public RegionConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Region");
            HasKey(x => x.RegionId);

            Property(x => x.RegionId).HasColumnName("RegionId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RegionName).HasColumnName("RegionName").IsRequired().HasMaxLength(100);
            Property(x => x.SortOrder).HasColumnName("SortOrder").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // SecurityMatrix
    internal partial class SecurityMatrixConfiguration : EntityTypeConfiguration<SecurityMatrix>
    {
        public SecurityMatrixConfiguration(string schema = "Security")
        {
            ToTable(schema + ".SecurityMatrix");
            HasKey(x => new { x.Resource, x.Operation, x.Role });

            Property(x => x.Resource).HasColumnName("Resource").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Operation).HasColumnName("Operation").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Role).HasColumnName("Role").IsRequired().HasMaxLength(50).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Value).HasColumnName("Value").IsRequired();
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsOptional().HasMaxLength(50);
            Property(x => x.CreatedDate).HasColumnName("CreatedDate").IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsOptional();
            Property(x => x.ModifiedBy).HasColumnName("ModifiedBy").IsOptional().HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // TimeZone
    internal partial class TimeZoneConfiguration : EntityTypeConfiguration<TimeZone>
    {
        public TimeZoneConfiguration(string schema = "Ref")
        {
            ToTable(schema + ".TimeZone");
            HasKey(x => x.TimeZoneId);

            Property(x => x.TimeZoneId).HasColumnName("TimeZoneId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            Property(x => x.Time).HasColumnName("Time").IsOptional().HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // UserProfile
    internal partial class UserProfileConfiguration : EntityTypeConfiguration<UserProfile>
    {
        public UserProfileConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".UserProfile");
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName("UserId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(100);
            Property(x => x.IsGroupAdmin).HasColumnName("IsGroupAdmin").IsOptional();
            Property(x => x.LastLogIn).HasColumnName("LastLogIn").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // vwGroupUserRoles
    internal partial class vwGroupUserRolesConfiguration : EntityTypeConfiguration<vwGroupUserRoles>
    {
        public vwGroupUserRolesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vwGroupUserRoles");
            HasKey(x => new { x.UserId, x.Username });

            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.Username).HasColumnName("Username").IsRequired().HasMaxLength(100);
            Property(x => x.ProjectRoles).HasColumnName("ProjectRoles").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // vwProjectUserRoles
    internal partial class vwProjectUserRolesConfiguration : EntityTypeConfiguration<vwProjectUserRoles>
    {
        public vwProjectUserRolesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vwProjectUserRoles");
            HasKey(x => new { x.UserId, x.UserName, x.ProjectId });

            Property(x => x.viewId).HasColumnName("viewId").IsOptional();
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(100);
            Property(x => x.ProjectId).HasColumnName("ProjectId").IsRequired();
            Property(x => x.ProjectRoles).HasColumnName("ProjectRoles").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // vwSecutiryMatrix
    internal partial class vwSecutiryMatrixConfiguration : EntityTypeConfiguration<vwSecutiryMatrix>
    {
        public vwSecutiryMatrixConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".vwSecutiryMatrix");
            HasKey(x => new { x.FunctionId, x.UserName, x.ProjectId });

            Property(x => x.FunctionName).HasColumnName("FunctionName").IsOptional().HasMaxLength(50);
            Property(x => x.FunctionId).HasColumnName("FunctionId").IsRequired();
            Property(x => x.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(100);
            Property(x => x.ProjectId).HasColumnName("ProjectId").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // webpages_Membership
    internal partial class webpages_MembershipConfiguration : EntityTypeConfiguration<webpages_Membership>
    {
        public webpages_MembershipConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".webpages_Membership");
            HasKey(x => x.UserId);

            Property(x => x.UserId).HasColumnName("UserId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CreateDate).HasColumnName("CreateDate").IsOptional();
            Property(x => x.ConfirmationToken).HasColumnName("ConfirmationToken").IsOptional().HasMaxLength(128);
            Property(x => x.IsConfirmed).HasColumnName("IsConfirmed").IsOptional();
            Property(x => x.LastPasswordFailureDate).HasColumnName("LastPasswordFailureDate").IsOptional();
            Property(x => x.PasswordFailuresSinceLastSuccess).HasColumnName("PasswordFailuresSinceLastSuccess").IsRequired();
            Property(x => x.Password).HasColumnName("Password").IsRequired().HasMaxLength(128);
            Property(x => x.PasswordChangedDate).HasColumnName("PasswordChangedDate").IsOptional();
            Property(x => x.PasswordSalt).HasColumnName("PasswordSalt").IsRequired().HasMaxLength(128);
            Property(x => x.PasswordVerificationToken).HasColumnName("PasswordVerificationToken").IsOptional().HasMaxLength(128);
            Property(x => x.PasswordVerificationTokenExpirationDate).HasColumnName("PasswordVerificationTokenExpirationDate").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // webpages_OAuthMembership
    internal partial class webpages_OAuthMembershipConfiguration : EntityTypeConfiguration<webpages_OAuthMembership>
    {
        public webpages_OAuthMembershipConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".webpages_OAuthMembership");
            HasKey(x => new { x.Provider, x.ProviderUserId });

            Property(x => x.Provider).HasColumnName("Provider").IsRequired().HasMaxLength(30).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProviderUserId).HasColumnName("ProviderUserId").IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.UserId).HasColumnName("UserId").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // webpages_Roles
    internal partial class webpages_RolesConfiguration : EntityTypeConfiguration<webpages_Roles>
    {
        public webpages_RolesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".webpages_Roles");
            HasKey(x => x.RoleId);

            Property(x => x.RoleId).HasColumnName("RoleId").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RoleName).HasColumnName("RoleName").IsRequired().HasMaxLength(256);
            HasMany(t => t.UserProfile).WithMany(t => t.webpages_Roles).Map(m => 
            {
                m.ToTable("webpages_UsersInRoles");
                m.MapLeftKey("RoleId");
                m.MapRightKey("UserId");
            });
            InitializePartial();
        }
        partial void InitializePartial();
    }

}

