//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------
using Nautilus.Dominio.Dto;
using Nautilus.Dominio.Dto.Anexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Servicio
{
    public interface IServicioNautilus
    {
        #region Producto
        InformacionDto InsertarProducto(ProductoDto pObjeto);
        InformacionDto ActualizarProducto(ProductoDto pObjeto);
        InformacionDto EliminarProducto(int pId);
        List<ProductoDto> ObtenerProducto();
        ProductoDto ObtenerProductoPorId(int pId);
        #endregion

        #region Configuración Producto
        InformacionDto InsertarConfiguracionProducto(ConfiguracionProductoDto pObjeto);
        InformacionDto ActualizarConfiguracionProducto(ConfiguracionProductoDto pObjeto);
        InformacionDto EliminarConfiguracionProducto(int pId);
        List<ConfiguracionProductoDto> ObtenerConfiguracionProducto();
        ConfiguracionProductoDto ObtenerConfiguracionProductoPorId(int pId);
        #endregion

        #region Empresa
        InformacionDto InsertarEmpresa(EmpresaDto pObjeto);
        InformacionDto ActualizarEmpresa(EmpresaDto pObjeto);
        InformacionDto EliminarEmpresa(int pId);
        List<EmpresaDto> ObtenerEmpresa();
        EmpresaDto ObtenerEmpresaPorId(int pId);
        #endregion

        #region Movimiento
        InformacionDto InsertarMovimiento(MovimientoDto pObjeto);
        InformacionDto ActualizarMovimiento(MovimientoDto pObjeto);
        InformacionDto EliminarMovimiento(int pId);
        List<MovimientoDto> ObtenerMovimiento();
        MovimientoDto ObtenerMovimientoPorId(int pId);
        #endregion

        #region Saldo Producto
        InformacionDto InsertarSaldoProducto(SaldoProductoDto pObjeto);
        InformacionDto ActualizarSaldoProducto(SaldoProductoDto pObjeto);
        InformacionDto EliminarSaldoProducto(int pId);
        List<SaldoProductoDto> ObtenerSaldoProducto();
        SaldoProductoDto ObtenerSaldoProductoPorId(int pId);
        #endregion

        #region Usuario
        InformacionDto InsertarUsuario(UsuarioDto pObjeto);
        InformacionDto ActualizarUsuario(UsuarioDto pObjeto);
        InformacionDto EliminarUsuario(int pId);
        List<UsuarioDto> ObtenerUsuario();
        UsuarioDto ObtenerUsuarioPorId(int pId);
        #endregion
    }
}
