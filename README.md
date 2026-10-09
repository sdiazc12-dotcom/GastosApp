# GastosApp

Proyecto de consola C# conectado a SQL Server (`GastosDB`) con ADO.NET[span_1](start_span)[span_1](end_span)[span_2](start_span)[span_2](end_span).

## Ejecución
1. Correr `script.sql` en SQL Server[span_3](start_span)[span_3](end_span).
2. Abrir la solución en Visual Studio y presionar `Ctrl + F5`[span_4](start_span)[span_4](end_span).

## Escenarios de prueba

### 1. Tres gastos iniciales
TOTAL GASTADO: Q 370.50[span_5](start_span)[span_5](end_span)[span_6](start_span)[span_6](end_span)
![Escenario 1](escenario1.png)

### 2. Cuarto gasto insertado
TOTAL GASTADO: Q 382.50[span_7](start_span)[span_7](end_span)[span_8](start_span)[span_8](end_span)
![Escenario 2](escenario2.png)

### 3. Tabla vacía
No hay gastos registrados[span_9](start_span)[span_9](end_span)[span_10](start_span)[span_10](end_span)
![Escenario 3](escenario3.png)

### 4. Base de datos inexistente
Se lanza `SqlException` porque la base de datos no existe en el servidor y aún no se usa `try/catch`[span_11](start_span)[span_11](end_span)[span_12](start_span)[span_12](end_span).
![Escenario 4](escenario4.png)

## Capturas

![Captura 1](Capturas/Cap1.png)
![Captura 2](Capturas/Cap2.png)
![Captura 3](Capturas/Cap3.png)
![Captura 4](Capturas/Cap4.png)
