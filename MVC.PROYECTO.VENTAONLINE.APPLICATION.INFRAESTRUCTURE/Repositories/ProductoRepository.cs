﻿using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Repositories;
using MVC.PROYECTO.VENTAONLINE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Repositories
{
    public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
    {
    }
}
