Console.WriteLine("MENU");
Console.WriteLine("1. Estudiante");
Console.WriteLine("2. Docente");
Console.WriteLine("3. Administrativo");
Console.WriteLine("4. Externo");
Console.WriteLine("Seleccionar una opción: ");
int opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        {
            Console.WriteLine("Ingrese monto base");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("MENU");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta");
            Console.WriteLine("3.  Transferencia");
            Console.WriteLine("Metodo de pago: ");
            int metodo = int.Parse(Console.ReadLine());
            switch (metodo)
            {
                case 1:
                    {
                        double descuentoefectivo = 0.10;
                        double descuentocupon = 0;
                        double recargo = 0;
                        Console.WriteLine("Tiene cupón: S/N");
                        string cupon=Console.ReadLine();
                        if (cupon =="S")
                        {
                            Console.WriteLine("Ingrese la primera letra del cupon: ");
                            string codigo= Console.ReadLine();
                            Console.WriteLine("Ingrese el numero final del cupon: ");
                            int numerofinal=int.Parse(Console.ReadLine());
                            if (codigo =="U"&& numerofinal%2==0)
                            {
                                Console.WriteLine("cupon valido");
                                descuentocupon = 0.15;
                            }
                            else
                            {
                                Console.WriteLine("Cupon invalido");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tiene cupon");
                        }
                        Console.WriteLine("Reporte antifraude (1-3): ");
                        int reporte = int.Parse(Console.ReadLine());

                        if (reporte == 2 || reporte == 3)
                        {
                            Console.WriteLine("Fraude detectado - descuentos anulados");

                            descuentoefectivo = 0;
                            descuentocupon = 0;
                            recargo = monto * 0.05;
                        }
                        else
                        {
                            Console.WriteLine("Sin fraude");
                        }
                        double totaldescuentos = (monto * descuentoefectivo) + descuentocupon;
                        double totalFinal = monto - totaldescuentos + recargo;
                        Console.WriteLine("RESUMEN DE FACTURA");
                        Console.WriteLine($"Monto: {monto}");
                        Console.WriteLine($"Descuento: {descuentoefectivo}");
                        Console.WriteLine($"Descuento de cupon: {descuentocupon}");
                        Console.WriteLine($"Total de descuento: {totaldescuentos}");
                        Console.WriteLine($"Recargo: {recargo}");
                        Console.WriteLine($"TOTAL FINAL: {totalFinal}");
                        break;
                    }
                case 2:
                    {
                        double descuentotarjeta= 0.06;
                        double descuentocupon = 0;
                        double recargo = 0;
                        Console.WriteLine("Tiene cupón: S/N");
                        string cupon = Console.ReadLine();
                        if (cupon == "S")
                        {
                            Console.WriteLine("Ingrese la primera letra del cupon: ");
                            string codigo = Console.ReadLine();
                            Console.WriteLine("Ingrese el numero final del cupon: ");
                            int numerofinal = int.Parse(Console.ReadLine());
                            if (codigo == "U" && numerofinal % 2 == 0)
                            {
                                Console.WriteLine("cupon valido");
                                descuentocupon = 0.15;
                            }
                            else
                            {
                                Console.WriteLine("Cupon invalido");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tiene cupon");
                        }
                        Console.WriteLine("Reporte antifraude (1-3): ");
                        int reporte = int.Parse(Console.ReadLine());

                        if (reporte == 2 || reporte == 3)
                        {
                            Console.WriteLine("Fraude detectado - descuentos anulados");

                            descuentotarjeta = 0;
                            descuentocupon = 0;
                            recargo = monto * 0.05;
                        }
                        else
                        {
                            Console.WriteLine("Sin fraude");
                        }
                        double totaldescuentos = monto *( descuentotarjeta + descuentocupon);
                        double totalFinal = monto - totaldescuentos + recargo;
                        Console.WriteLine("RESUMEN DE FACTURA");
                        Console.WriteLine($"Monto: {monto}");
                        Console.WriteLine($"Descuento: {descuentotarjeta}");
                        Console.WriteLine($"Descuento de cupon: {descuentocupon}");
                        Console.WriteLine($"Total de descuento: {totaldescuentos}");
                        Console.WriteLine($"Recargo: {recargo}");
                        Console.WriteLine($"TOTAL FINAL: {totalFinal}");
                        break;
                    }
                case 3:
                    {
                        double descuentotransferencia= 0.05;
                        double descuentocupon = 0;
                        double recargo = 0;
                        Console.WriteLine("Tiene cupón: S/N");
                        string cupon = Console.ReadLine();
                        if (cupon == "S")
                        {
                            Console.WriteLine("Ingrese la primera letra del cupon: ");
                            string codigo = Console.ReadLine();
                            Console.WriteLine("Ingrese el numero final del cupon: ");
                            int numerofinal = int.Parse(Console.ReadLine());
                            if (codigo == "U" && numerofinal % 2 == 0)
                            {
                                Console.WriteLine("cupon valido");
                                descuentocupon = 0.10;
                            }
                            else
                            {
                                Console.WriteLine("Cupon invalido");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No tiene cupon");
                        }
                        Console.WriteLine("Reporte antifraude (1-3): ");
                        int reporte = int.Parse(Console.ReadLine());

                        if (reporte == 2 || reporte == 3)
                        {
                            Console.WriteLine("Fraude detectado - descuentos anulados");

                            descuentotransferencia = 0;
                            descuentocupon = 0;
                            recargo = monto * 0.07;
                        }
                        else
                        {
                            Console.WriteLine("Sin fraude");
                        }
                        double totaldescuentos = monto * (descuentotransferencia + descuentocupon);
                        double totalFinal = monto - totaldescuentos + recargo;
                        Console.WriteLine("RESUMEN DE FACTURA");
                        Console.WriteLine($"Monto: {monto}");
                        Console.WriteLine($"Descuento: {descuentotransferencia}");
                        Console.WriteLine($"Descuento de cupon: {descuentocupon}");
                        Console.WriteLine($"Total de descuento: {totaldescuentos}");
                        Console.WriteLine($"Recargo: {recargo}");
                        Console.WriteLine($"TOTAL FINAL: {totalFinal}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    break;
            }
            break;
        }
    case 2:
        {
            Console.WriteLine("Ingrese monto base");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("MENU");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta");
            Console.WriteLine("3.  Transferencia");
            Console.WriteLine("Metodo de pago: ");
            int metodo = int.Parse(Console.ReadLine());
            switch (metodo)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    break;
            }
            break;
        }
    case 3:
        {
            Console.WriteLine("Ingrese monto base");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("MENU");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta");
            Console.WriteLine("3.  Transferencia");
            Console.WriteLine("Metodo de pago: ");
            int metodo = int.Parse(Console.ReadLine());
            switch (metodo)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    break;
            }
            break;
        }
    case 4:
        {
            Console.WriteLine("Ingrese monto base");
            double monto = double.Parse(Console.ReadLine());
            Console.WriteLine("MENU");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta");
            Console.WriteLine("3.  Transferencia");
            Console.WriteLine("Metodo de pago: ");
            int metodo = int.Parse(Console.ReadLine());
            switch (metodo)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opción no válida");
                    }
                    break;
            }
            break;
        }
    default:
        {
            Console.WriteLine("Opción no válida");
        }
        break;
}