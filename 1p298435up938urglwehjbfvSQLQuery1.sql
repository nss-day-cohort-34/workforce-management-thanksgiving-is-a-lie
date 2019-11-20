﻿SELECT 
                                            c.PurchaseDate, 
                                            IsNull(c.DecomissionDate, '') AS DecomissionDate, 
                                            c.Make,            
                                            c.Manufacturer,
                                            isNull(e.FirstName + ' ' +
                                            e.LastName, '') AS ComputerEmployee,
                                            e.Id AS EmployeeId,
                                            c.Id AS ComputerId
                                       FROM ComputerEmployee ce
                                       LEFT JOIN Employee e ON e.Id = ce.EmployeeId
                                       FULL OUTER JOIN Computer c ON c.Id = ce.ComputerId
									   WHERE c.Manufacturer LIKE '%Apple%'

									   select * from Employee