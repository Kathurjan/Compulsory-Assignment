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
