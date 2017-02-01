CREATE PROCEDURE getMortalityIndicator(    
@countryCode varchar(3),    
@startYear varchar(4),    
@endYear varchar(4)    
)    
AS    
BEGIN    
 SELECT  COUNTRYNAME [CountryName],SUM(round(CONVERT(FLOAT,I.VALUE),2))[Rate],YEAR [Year] ,'MORTALITY'[Description]   
 FROM Indicators I    
 WHERE    
 INDICATORNAME LIKE '%MORTALITY%'    
 AND YEAR between @startYear and @endYear    
 AND COUNTRYCODE = @countryCode    
 GROUP BY YEAR, COUNTRYNAME    
 ORDER BY YEAR,RATE ASC    
END  
  