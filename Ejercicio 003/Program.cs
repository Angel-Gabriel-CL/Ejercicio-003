 // Encabezado con el planteamiento del problema
            Console.WriteLine("==========================================================================");
            Console.WriteLine(" EJERCICIO 3: SIMULACIÓN DE CARGA DE UNA BATERÍA DE 12.6 V");
            Console.WriteLine(" Muestra el número de ciclo y voltaje actual hasta alcanzar o superar 12.6V.");
            Console.WriteLine("==========================================================================\n");

            // Lectura de datos de entrada
            Console.Write("Ingrese el voltaje inicial de la batería (V): ");
            double voltajeInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el incremento de voltaje por ciclo (V): ");
            double incremento = Convert.ToDouble(Console.ReadLine());

            // Validación de la entrada
            if (incremento <= 0)
            {
                Console.WriteLine("\n[ERROR]: El incremento introducido es igual o menor que cero.");
                Console.WriteLine("La simulación no se ejecutará.");
            }
            else
            {
                double voltajeActual = voltajeInicial;
                int ciclo = 0;

                Console.WriteLine("\n--- Inicio del Proceso de Carga ---");

                // Ciclo de carga mediante while
                while (voltajeActual < 12.6)
                {
                    ciclo++;
                    voltajeActual += incremento;
                    Console.WriteLine($"Ciclo {ciclo}: Voltaje actual = {voltajeActual:F2} V");
                }

                Console.WriteLine($"\nProceso finalizado. Batería cargada al nivel requerido ({voltajeActual:F2} V).");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
     