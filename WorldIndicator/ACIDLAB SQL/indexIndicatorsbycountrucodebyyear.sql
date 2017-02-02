   CREATE NONCLUSTERED INDEX [indexIndicatorsbycountrucodebyyear]
ON [dbo].[Indicators] ([CountryCode],[Year])
INCLUDE ([CountryName],[IndicatorName],[Value])
WITH(ONLINE=ON);