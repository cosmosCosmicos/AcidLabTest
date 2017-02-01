USE WorldIndicator;
GO
CREATE PROCEDURE GetAllCountries
AS
BEGIN 

SELECT CountryCode,ShortName [CountryName] FROM WorldIndicator..Country 

END