﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicalComponents.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MainDatabaseEntities6 : DbContext
    {
        public MainDatabaseEntities6()
            : base("name=MainDatabaseEntities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BrokenRequest> BrokenRequest { get; set; }
        public virtual DbSet<ElementsDragMetal> ElementsDragMetal { get; set; }
        public virtual DbSet<ElementsPlaces> ElementsPlaces { get; set; }
        public virtual DbSet<FaticalPhysicalPeoplePositions> FaticalPhysicalPeoplePositions { get; set; }
        public virtual DbSet<ModelElement> ModelElement { get; set; }
        public virtual DbSet<ModelToPurchase> ModelToPurchase { get; set; }
        public virtual DbSet<ModelType> ModelType { get; set; }
        public virtual DbSet<MOExpluatation> MOExpluatation { get; set; }
        public virtual DbSet<Organisations> Organisations { get; set; }
        public virtual DbSet<PersonalOnService> PersonalOnService { get; set; }
        public virtual DbSet<PhysicalPeople> PhysicalPeople { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<PurchaseElements> PurchaseElements { get; set; }
        public virtual DbSet<sp_BrokenRequestReason> sp_BrokenRequestReason { get; set; }
        public virtual DbSet<sp_Corpus> sp_Corpus { get; set; }
        public virtual DbSet<sp_CountryKey> sp_CountryKey { get; set; }
        public virtual DbSet<sp_DragMetal> sp_DragMetal { get; set; }
        public virtual DbSet<sp_ExpluatationRole> sp_ExpluatationRole { get; set; }
        public virtual DbSet<sp_FunctionalyUseModel> sp_FunctionalyUseModel { get; set; }
        public virtual DbSet<sp_MoveReason> sp_MoveReason { get; set; }
        public virtual DbSet<sp_OrganisationDepartment> sp_OrganisationDepartment { get; set; }
        public virtual DbSet<sp_OrganisationType> sp_OrganisationType { get; set; }
        public virtual DbSet<sp_PurchaseType> sp_PurchaseType { get; set; }
        public virtual DbSet<sp_PysicalPeoplePositions> sp_PysicalPeoplePositions { get; set; }
        public virtual DbSet<sp_ReasonWriteOff> sp_ReasonWriteOff { get; set; }
        public virtual DbSet<sp_ServiceOperationPersonalRole> sp_ServiceOperationPersonalRole { get; set; }
        public virtual DbSet<sp_ServiceOperationType> sp_ServiceOperationType { get; set; }
        public virtual DbSet<sp_ServiceType> sp_ServiceType { get; set; }
        public virtual DbSet<sp_Standarts> sp_Standarts { get; set; }
        public virtual DbSet<sp_ZIP_AND_PM_Element> sp_ZIP_AND_PM_Element { get; set; }
        public virtual DbSet<ZIPPMDocumentsOnPurchase> ZIPPMDocumentsOnPurchase { get; set; }
        public virtual DbSet<ZIPPMMoves> ZIPPMMoves { get; set; }
        public virtual DbSet<ZIPPMonStock> ZIPPMonStock { get; set; }
    }
}
