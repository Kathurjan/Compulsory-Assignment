# Compulsory Assignment
 Compulsory Assignment for databases for Developers Manual SQL scripts with rollback

 
## Manual Setup Guide:
1. To setup the db and the intial db run the SQLQuery1.sql
2. To add the Categories tables with FK_constraints run the 2_AddTableCategoriesAndFK.sql-migration schema script
3. To add the last table run the V3_CreateProductRatingTable.sql migration schema

## Manual Roll-Back Guide
Incase you want to roll-back to a previous version of the DB-Schema 
Depending on which version you are in, you would need to start by
1. Running V3_UndoProductRatingScript.sql
2. Then V2_UndoProductCategories.sql

## Setup insructions
1. In case something is wrong with NuGet - dotnet restore
2. Be sure you have installed .NET version 8.0.0

## EF Roll-Back Guide
Incase you want to roll-back to a previous version of the DB-Schema 
Depending on which version you are in, you would need to start by
1. Running 1st down command:
    -In the Package Manager Console:

        Update-Database -Migration 20240302112832_CreateProductRatingTable
     Or
    -In Bash:

        dotnet ef database update 20240302112832_CreateProductRatingTable
2. Running 2nd down command:
    -In the Package Manager Console:

        Update-Database -Migration 20240228203640_CategoriesAndProductCategoryLink
     Or
    -In Bash:

        dotnet ef database update 20240228203640_CategoriesAndProductCategoryLink
3. Running 3rd down command:
    -In the Package Manager Console:

        Update-Database -Migration 20240228090950_InitialCreate

     Or
    -In Bash:

        dotnet ef database update 20240228090950_InitialCreate