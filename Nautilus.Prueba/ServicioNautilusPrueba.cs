//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nautilus.Dominio.Dto;
using Nautilus.Servicio;
using System.Collections.Generic;
using Nautilus.Dominio.Dto.Anexo;
using Nautilus.Dominio.Complemento.Enumerador;

namespace Nautilus.Prueba
{
    [TestClass]
    public class ServicioNautilusPrueba
    {
        IServicioNautilus _servicioNautilus;
        private int _IdRegistrado;

        public ServicioNautilusPrueba()
        {
            _servicioNautilus = new ServicioNautilus();
        }

        #region Pruebas Producto
        [TestMethod]
        public void InsertarProducto_Correcto_Prueba()
        {
            InformacionDto vResultado = _servicioNautilus.InsertarProducto(ObtenerProducto());
            _IdRegistrado = (int)vResultado.Objeto;

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ActualizarProducto_Correcto_Prueba()
        {
            InsertarProducto_Correcto_Prueba();
            ProductoDto vObjeto = _servicioNautilus.ObtenerProductoPorId(_IdRegistrado);
            vObjeto.Codigo = "codecofe";
            InformacionDto vResultado = _servicioNautilus.ActualizarProducto(vObjeto);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void EliminarProducto_Correcto_Prueba()
        {
            InsertarProducto_Correcto_Prueba();
            InformacionDto vResultado = _servicioNautilus.EliminarProducto(_IdRegistrado);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ObtenerProductoPorId_Correcto_Prueba()
        {
            InsertarProducto_Correcto_Prueba();
            ProductoDto vObjeto = _servicioNautilus.ObtenerProductoPorId(_IdRegistrado);

            Assert.IsNotNull(vObjeto);
        }

        [TestMethod]
        public void ObtenerProducto_Correcto_Prueba()
        {
            List<ProductoDto> vListaObjeto = _servicioNautilus.ObtenerProducto();

            Assert.IsTrue(vListaObjeto.Count > 0);
        }

        #endregion

        #region Prueba Configuración Producto
        [TestMethod]
        public void InsertarConfiguracionProducto_Correcto_Prueba()
        {
            InformacionDto vResultado = _servicioNautilus.InsertarConfiguracionProducto(ObtenerConfiguracionProducto());
            _IdRegistrado = (int)vResultado.Objeto;

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ActualizarConfiguracionProducto_Correcto_Prueba()
        {
            InsertarConfiguracionProducto_Correcto_Prueba();
            ConfiguracionProductoDto vObjeto = _servicioNautilus.ObtenerConfiguracionProductoPorId(_IdRegistrado);
            vObjeto.PrecioVenta = 200;
            InformacionDto vResultado = _servicioNautilus.ActualizarConfiguracionProducto(vObjeto);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void EliminarConfiguracionProducto_Correcto_Prueba()
        {
            InsertarConfiguracionProducto_Correcto_Prueba();
            InformacionDto vResultado = _servicioNautilus.EliminarConfiguracionProducto(_IdRegistrado);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ObtenerConfiguracionProductoPorId_Correcto_Prueba()
        {
            InsertarConfiguracionProducto_Correcto_Prueba();
            ConfiguracionProductoDto vObjeto = _servicioNautilus.ObtenerConfiguracionProductoPorId(_IdRegistrado);

            Assert.IsNotNull(vObjeto);
        }

        [TestMethod]
        public void ObtenerConfiguracionProducto_Correcto_Prueba()
        {
            List<ConfiguracionProductoDto> vListaObjeto = _servicioNautilus.ObtenerConfiguracionProducto();

            Assert.IsTrue(vListaObjeto.Count > 0);
        }
        #endregion

        #region Prueba Empresa
        [TestMethod]
        public void InsertarEmpresa_Correcto_Prueba()
        {
            InformacionDto vResultado = _servicioNautilus.InsertarEmpresa(ObtenerEmpresa());
            _IdRegistrado = (int)vResultado.Objeto;

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ActualizarEmpresa_Correcto_Prueba()
        {
            InsertarEmpresa_Correcto_Prueba();
            EmpresaDto vObjeto = _servicioNautilus.ObtenerEmpresaPorId(_IdRegistrado);
            vObjeto.Telefono = "111";
            InformacionDto vResultado = _servicioNautilus.ActualizarEmpresa(vObjeto);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void EliminarEmpresa_Correcto_Prueba()
        {
            InsertarEmpresa_Correcto_Prueba();
            InformacionDto vResultado = _servicioNautilus.EliminarEmpresa(_IdRegistrado);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ObtenerEmpresaPorId_Correcto_Prueba()
        {
            InsertarEmpresa_Correcto_Prueba();
            EmpresaDto vObjeto = _servicioNautilus.ObtenerEmpresaPorId(_IdRegistrado);

            Assert.IsNotNull(vObjeto);
        }

        [TestMethod]
        public void ObtenerEmpresa_Correcto_Prueba()
        {
            List<EmpresaDto> vListaObjeto = _servicioNautilus.ObtenerEmpresa();

            Assert.IsTrue(vListaObjeto.Count > 0);
        }
        #endregion

        #region Prueba Movimiento
        [TestMethod]
        public void InsertarMovimiento_Correcto_Prueba()
        {
            InformacionDto vResultado = _servicioNautilus.InsertarMovimiento(ObtenerMovimiento());
            _IdRegistrado = (int)vResultado.Objeto;

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ActualizarMovimiento_Correcto_Prueba()
        {
            InsertarMovimiento_Correcto_Prueba();
            MovimientoDto vObjeto = _servicioNautilus.ObtenerMovimientoPorId(_IdRegistrado);
            vObjeto.Cantidad = 11;
            InformacionDto vResultado = _servicioNautilus.ActualizarMovimiento(vObjeto);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void EliminarMovimiento_Correcto_Prueba()
        {
            InsertarMovimiento_Correcto_Prueba();
            InformacionDto vResultado = _servicioNautilus.EliminarMovimiento(_IdRegistrado);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ObtenerMovimientoPorId_Correcto_Prueba()
        {
            InsertarMovimiento_Correcto_Prueba();
            MovimientoDto vObjeto = _servicioNautilus.ObtenerMovimientoPorId(_IdRegistrado);

            Assert.IsNotNull(vObjeto);
        }

        [TestMethod]
        public void ObtenerMovimiento_Correcto_Prueba()
        {
            List<MovimientoDto> vListaObjeto = _servicioNautilus.ObtenerMovimiento();

            Assert.IsTrue(vListaObjeto.Count > 0);
        }
        #endregion

        #region Prueba Saldo Producto
        [TestMethod]
        public void InsertarSaldoProducto_Correcto_Prueba()
        {
            InformacionDto vResultado = _servicioNautilus.InsertarSaldoProducto(ObtenerSaldoProducto());
            _IdRegistrado = (int)vResultado.Objeto;

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ActualizarSaldoProducto_Correcto_Prueba()
        {
            InsertarSaldoProducto_Correcto_Prueba();
            SaldoProductoDto vObjeto = _servicioNautilus.ObtenerSaldoProductoPorId(_IdRegistrado);
            vObjeto.Cantidad = 50;
            InformacionDto vResultado = _servicioNautilus.ActualizarSaldoProducto(vObjeto);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void EliminarSaldoProducto_Correcto_Prueba()
        {
            InsertarSaldoProducto_Correcto_Prueba();
            InformacionDto vResultado = _servicioNautilus.EliminarSaldoProducto(_IdRegistrado);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ObtenerSaldoProductoPorId_Correcto_Prueba()
        {
            InsertarSaldoProducto_Correcto_Prueba();
            SaldoProductoDto vObjeto = _servicioNautilus.ObtenerSaldoProductoPorId(_IdRegistrado);

            Assert.IsNotNull(vObjeto);
        }

        [TestMethod]
        public void ObtenerSaldoProducto_Correcto_Prueba()
        {
            List<SaldoProductoDto> vListaObjeto = _servicioNautilus.ObtenerSaldoProducto();

            Assert.IsTrue(vListaObjeto.Count > 0);
        }
        #endregion

        #region Prueba Usuario
        [TestMethod]
        public void InsertarUsuario_Correcto_Prueba()
        {
            InformacionDto vResultado = _servicioNautilus.InsertarUsuario(ObtenerUsuario());
            _IdRegistrado = (int)vResultado.Objeto;

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ActualizarUsuario_Correcto_Prueba()
        {
            InsertarUsuario_Correcto_Prueba();
            UsuarioDto vObjeto = _servicioNautilus.ObtenerUsuarioPorId(_IdRegistrado);
            vObjeto.EsActivo = false;
            InformacionDto vResultado = _servicioNautilus.ActualizarUsuario(vObjeto);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void EliminarUsuario_Correcto_Prueba()
        {
            InsertarUsuario_Correcto_Prueba();
            InformacionDto vResultado = _servicioNautilus.EliminarUsuario(_IdRegistrado);

            Assert.IsTrue(vResultado.EsCorrecto);
        }

        [TestMethod]
        public void ObtenerUsuarioPorId_Correcto_Prueba()
        {
            InsertarUsuario_Correcto_Prueba();
            UsuarioDto vObjeto = _servicioNautilus.ObtenerUsuarioPorId(_IdRegistrado);

            Assert.IsNotNull(vObjeto);
        }

        [TestMethod]
        public void ObtenerUsuario_Correcto_Prueba()
        {
            List<UsuarioDto> vListaObjeto = _servicioNautilus.ObtenerUsuario();

            Assert.IsTrue(vListaObjeto.Count > 0);
        }
        #endregion

        #region Mètodos Auxiliares

        private ConfiguracionProductoDto ObtenerConfiguracionProducto()
        {
            InsertarProducto_Correcto_Prueba();

            return new ConfiguracionProductoDto
            {
                BitacoraUsuario = "Prueba",
                PrecioVenta = 100,
                ProductoId = _IdRegistrado
            };
        }

        private ProductoDto ObtenerProducto()
        {
            return new ProductoDto()
            {

                BitacoraUsuario = "Prueba",
                Nombre = "software codecofe",
                PrecioUnitario = 500,
                TipoUnidad = "Unidad"
            };
        }

        private EmpresaDto ObtenerEmpresa()
        {
            return new EmpresaDto
            {
                Celular = "+591 72483556",
                Email = "contact@codecofe.com",
                EmailCeo = "jlrodriguez.codecofe@gmail.com",
                Nit = "123",
                Nombre = "CODECOFE",
                NombreCeo = "jose luis",
                NumDocCeo = "234324",
                Site = "www.codecofe.com",
                Skype = "jlrodriguez.codecofe",
                Telefono = "2343"
            };
        }

        private MovimientoDto ObtenerMovimiento()
        {
            InsertarProducto_Correcto_Prueba();

            return new MovimientoDto
            {
                BitacoraUsuario = "Prueba",
                Cantidad = 23,
                ProductoId = _IdRegistrado,
                TipoMovimiento = eTipoMovimiento.E
            };
        }

        private SaldoProductoDto ObtenerSaldoProducto()
        {
            InsertarProducto_Correcto_Prueba();

            return new SaldoProductoDto
            {
                Cantidad = 10,
                ProductoId = _IdRegistrado
            };
        }

        private UsuarioDto ObtenerUsuario()
        {
            InsertarEmpresa_Correcto_Prueba();

            return new UsuarioDto
            {
                Contrasenia = "Alfaad",
                Email = "jlrodriguez.codecofe@gmail.com",
                EmpresaId = _IdRegistrado,
                EsActivo = true,
                FechaDesde = DateTime.Now,
                FechaHasta = DateTime.Now,
                Nombre = "jose luis",
                Telefono = "+591 72483556"
            };
        }
        #endregion
    }
}
