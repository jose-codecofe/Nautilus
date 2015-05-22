//------------------------------------------------------------------------------
// <codecofe>
//     Este código se elaboro por CodeCofe.
//
//     Para recibir informaciòn usted puede contactarnos desde los siguientes medios:
//     wwww.codecofe.com  contact@codecofe.com  jlrodriguez.codecofe@gmail.com  +591 72483556.
// </codecofe>
//------------------------------------------------------------------------------

using Nautilus.Data.ORM;
using Nautilus.Dominio.Complemento.Enumerador;
using Nautilus.Dominio.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nautilus.Dominio.Complemento
{
    public static class Mapeador
    {
        #region Producto
        public static ProductoDto MapearEntidadADto(producto pEntidad)
        {
            if (pEntidad == null)
                return null;
            else
            {
                return new ProductoDto
                {
                    BitacoraFecha = pEntidad.bitacora_fecha,
                    BitacoraUsuario = pEntidad.bitacora_usuario,
                    Codigo = pEntidad.codigo,
                    Detalle = pEntidad.detalle,
                    Id = pEntidad.Id,
                    Nombre = pEntidad.nombre,
                    Observacion = pEntidad.observacion,
                    PrecioUnitario = pEntidad.precio_unitario,
                    TipoUnidad = pEntidad.tipo_unidad
                };
            }
        }

        public static producto MapearDtoAEntidad(ProductoDto pDto)
        {
            if (pDto == null)
                return null;
            else
            {
                return new producto
                {
                    bitacora_fecha = pDto.BitacoraFecha,
                    bitacora_usuario = pDto.BitacoraUsuario,
                    codigo = pDto.Codigo,
                    detalle = pDto.Detalle,
                    Id = pDto.Id,
                    nombre = pDto.Nombre,
                    observacion = pDto.Observacion,
                    precio_unitario = pDto.PrecioUnitario,
                    tipo_unidad = pDto.TipoUnidad
                };
            }

        }

        public static List<ProductoDto> MapearListaEntidadAListaDto(List<producto> pListaEntidad)
        {
            List<ProductoDto> vListaDto = new List<ProductoDto>();
            pListaEntidad.ForEach(vEntidad => { vListaDto.Add(MapearEntidadADto(vEntidad)); });
            return vListaDto;
        }
        #endregion

        #region Configuracion Producto
        public static ConfiguracionProductoDto MapearEntidadADto(configuracion_productos pEntidad)
        {
            if (pEntidad == null)
                return null;
            else
            {
                return new ConfiguracionProductoDto
                {
                    BitacoraFecha = pEntidad.bitacora_fecha,
                    BitacoraUsuario = pEntidad.bitacora_usuario,
                    Id = pEntidad.Id,
                    PrecioVenta = pEntidad.precio_venta,
                    ProductoId = pEntidad.producto_Id
                };
            }
        }

        public static configuracion_productos MapearDtoAEntidad(ConfiguracionProductoDto pDto)
        {
            if (pDto == null)
                return null;
            else
            {
                return new configuracion_productos
                {
                    bitacora_fecha = pDto.BitacoraFecha,
                    bitacora_usuario = pDto.BitacoraUsuario,
                    Id = pDto.Id,
                    precio_venta = pDto.PrecioVenta,
                    producto_Id = pDto.ProductoId
                };
            }

        }

        public static List<ConfiguracionProductoDto> MapearListaEntidadAListaDto(List<configuracion_productos> pListaEntidad)
        {
            List<ConfiguracionProductoDto> vListaDto = new List<ConfiguracionProductoDto>();
            pListaEntidad.ForEach(vEntidad => { vListaDto.Add(MapearEntidadADto(vEntidad)); });
            return vListaDto;
        }
        #endregion

        #region Empresa
        public static EmpresaDto MapearEntidadADto(empresa pEntidad)
        {
            if (pEntidad == null)
                return null;
            else
            {
                return new EmpresaDto
                {
                    Celular = pEntidad.celular,
                    Email = pEntidad.email,
                    EmailCeo = pEntidad.email_ceo,
                    Id = pEntidad.Id,
                    Nit = pEntidad.nit,
                    Nombre = pEntidad.nombre,
                    NombreCeo = pEntidad.nombre_ceo,
                    NumDocCeo = pEntidad.num_doc_ceo,
                    Site = pEntidad.site,
                    Skype = pEntidad.skype,
                    Telefono = pEntidad.telefono
                };
            }
        }

        public static empresa MapearDtoAEntidad(EmpresaDto pDto)
        {
            if (pDto == null)
                return null;
            else
            {
                return new empresa
                {
                    celular = pDto.Celular,
                    email = pDto.Email,
                    email_ceo = pDto.EmailCeo,
                    Id = pDto.Id,
                    nit = pDto.Nit,
                    nombre = pDto.Nombre,
                    nombre_ceo = pDto.NombreCeo,
                    num_doc_ceo = pDto.NumDocCeo,
                    site = pDto.Site,
                    skype = pDto.Skype,
                    telefono = pDto.Telefono
                };
            }

        }

        public static List<EmpresaDto> MapearListaEntidadAListaDto(List<empresa> pListaEntidad)
        {
            List<EmpresaDto> vListaDto = new List<EmpresaDto>();
            pListaEntidad.ForEach(vEntidad => { vListaDto.Add(MapearEntidadADto(vEntidad)); });
            return vListaDto;
        }
        #endregion

        #region Movimiento
        public static MovimientoDto MapearEntidadADto(movimiento pEntidad)
        {
            if (pEntidad == null)
                return null;
            else
            {
                return new MovimientoDto
                {
                    BitacoraFecha = pEntidad.bitacora_fecha,
                    BitacoraUsuario = pEntidad.bitacora_usuario,
                    Cantidad = pEntidad.cantidad,
                    Id = pEntidad.Id,
                    ProductoId = pEntidad.producto_Id,
                    TipoMovimiento = (eTipoMovimiento)Enum.Parse(typeof(eTipoMovimiento), pEntidad.tipo_movimiento)
                };
            }
        }

        public static movimiento MapearDtoAEntidad(MovimientoDto pDto)
        {
            if (pDto == null)
                return null;
            else
            {
                return new movimiento
                {
                    bitacora_fecha = pDto.BitacoraFecha,
                    bitacora_usuario = pDto.BitacoraUsuario,
                    cantidad = pDto.Cantidad,
                    Id = pDto.Id,
                    producto_Id = pDto.ProductoId,
                    tipo_movimiento = pDto.TipoMovimiento.ToString()
                };
            }

        }

        public static List<MovimientoDto> MapearListaEntidadAListaDto(List<movimiento> pListaEntidad)
        {
            List<MovimientoDto> vListaDto = new List<MovimientoDto>();
            pListaEntidad.ForEach(vEntidad => { vListaDto.Add(MapearEntidadADto(vEntidad)); });
            return vListaDto;
        }
        #endregion

        #region Saldo Producto
        public static SaldoProductoDto MapearEntidadADto(saldo_productos pEntidad)
        {
            if (pEntidad == null)
                return null;
            else
            {
                return new SaldoProductoDto
                {
                    Cantidad = pEntidad.cantidad,
                    Id = pEntidad.Id,
                    ProductoId = pEntidad.producto_Id
                };
            }
        }

        public static saldo_productos MapearDtoAEntidad(SaldoProductoDto pDto)
        {
            if (pDto == null)
                return null;
            else
            {
                return new saldo_productos
                {
                    cantidad = pDto.Cantidad,
                    Id = pDto.Id,
                    producto_Id = pDto.ProductoId
                };
            }

        }

        public static List<SaldoProductoDto> MapearListaEntidadAListaDto(List<saldo_productos> pListaEntidad)
        {
            List<SaldoProductoDto> vListaDto = new List<SaldoProductoDto>();
            pListaEntidad.ForEach(vEntidad => { vListaDto.Add(MapearEntidadADto(vEntidad)); });
            return vListaDto;
        }
        #endregion

        #region Usuario
        public static UsuarioDto MapearEntidadADto(usuario pEntidad)
        {
            if (pEntidad == null)
                return null;
            else
            {
                return new UsuarioDto
                {
                    Contrasenia = pEntidad.contrasenia,
                    Email = pEntidad.email,
                    EmpresaId = pEntidad.empresa_Id,
                   // EsActivo = pEntidad.es_activo,
                    FechaDesde = pEntidad.fecha_desde,
                    FechaHasta = pEntidad.fecha_hasta,
                    Id = pEntidad.Id,
                    Nombre = pEntidad.nombre,
                    Telefono = pEntidad.telefono
                };
            }
        }

        public static usuario MapearDtoAEntidad(UsuarioDto pDto)
        {
            if (pDto == null)
                return null;
            else
            {
                return new usuario
                {
                    contrasenia = pDto.Contrasenia,
                    email = pDto.Email,
                    empresa_Id = pDto.EmpresaId,
                   // es_activo = pDto.EsActivo,
                    fecha_desde = pDto.FechaDesde,
                    fecha_hasta = pDto.FechaHasta,
                    Id = pDto.Id,
                    nombre = pDto.Nombre,
                    telefono = pDto.Telefono
                };
            }

        }

        public static List<UsuarioDto> MapearListaEntidadAListaDto(List<usuario> pListaEntidad)
        {
            List<UsuarioDto> vListaDto = new List<UsuarioDto>();
            pListaEntidad.ForEach(vEntidad => { vListaDto.Add(MapearEntidadADto(vEntidad)); });
            return vListaDto;
        }
        #endregion
    }
}
