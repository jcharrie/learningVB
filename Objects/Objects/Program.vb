Imports System

Module Program
    Sub Main()
        'Create a new car object
        'Dim objCar As New SportsCar
        Using objCar As New SportsCar
            'Set the horsepower and weight(kg)
            objCar.HorsePower = 240
            objCar.Weight = 1085

            'Display the details of the car
            DisplayCarDetails(objCar)
            DisplaySportsCarDetails(objCar)

            'Dispose of the object
            objCar.Dispose()
            'objCar = Nothing
        End Using



        'Wait for input from the user
        Console.ReadLine()

    End Sub

    'DisplayCarDetails-procedure that displays a car's details
    Sub DisplayCarDetails(theCar As CarPerformance.Car)
        'Display the details of the car
        Console.WriteLine("Color: " & theCar.Color)
        Console.WriteLine("Number of doors: " & theCar.NumberOfDoors)
        Console.WriteLine("Current speed: " & theCar.Speed)
        Console.WriteLine("Acceleration rate: " & theCar.CalculateAccelerationRate)
    End Sub

    'DisplaySportsCarDetails-procedure that displays a sports car's details
    Sub DisplaySportsCarDetails(theCar As SportsCar)
        'Display the details of the sports car
        Console.WriteLine()
        Console.WriteLine("Sports Car Horsepower: " & theCar.HorsePower)
        Console.WriteLine("Sports Car Weight: " & theCar.Weight)
        Console.WriteLine("Power to Weight Ratio: " & theCar.GetPowerToWeightRatio)
    End Sub

End Module
