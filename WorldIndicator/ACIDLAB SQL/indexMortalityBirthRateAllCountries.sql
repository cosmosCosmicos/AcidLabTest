/*
Missing Index Details from SQLQuery8.sql - (local).WorldIndicator (AIEP\Mario Guiloff S (52))
The Query Processor estimates that implementing the following index could improve the query cost by 62.544%.
*/

/*
USE [WorldIndicator]
GO
CREATE NONCLUSTERED INDEX [<Name of Missing Index, sysname,>]
ON [dbo].[Indicators] ([Year])
INCLUDE ([CountryName],[IndicatorName],[Value])
GO
*/

CREATE NONCLUSTERED INDEX [indexMortalityBirthRateAllCountries]
ON [dbo].[Indicators] ([Year])
INCLUDE ([CountryName],[IndicatorName],[Value])
WITH(ONLINE=ON);
