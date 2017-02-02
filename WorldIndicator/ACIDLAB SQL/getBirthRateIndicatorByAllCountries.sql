CREATE PROCEDURE getBirthRateIndicatorByAllCountries(       
@startYear varchar(4),      
@endYear varchar(4)      
)      
AS      
BEGIN      
 SELECT  COUNTRYNAME [CountryName],SUM(round(CONVERT(FLOAT,I.VALUE),2))[Rate],YEAR [Year],  'BIRTH RATE'[Description]    
 FROM WorldIndicator..indicators I      
 WHERE       
 INDICATORNAME LIKE '%BIRTH RATE%'       
 AND YEAR between @startYear and @endYear        
 GROUP BY YEAR, COUNTRYNAME      
 ORDER BY RATE ASC      
END 