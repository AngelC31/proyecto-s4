import { useState } from "react"

const modeloUsuario = {
    idUsuario: 0,
    nombre: "",
    apellido: "",
    correo: "",
    contra: ""
}

const Formulario = ({ guardarUsuario }) => {
    const [usuario, setUsuario] = useState(modeloUsuario);
    const actualizarDato = (e) => {
        console.log(e.target.name + " " + e.target.value);
        setUsuario({
            ...usuario,
            [e.target.name]: e.target.value,
        })
    }
    const enviarDatos = () => {
        if (usuario.idUsuario === null) {
            guardarUsuario(usuario)
        }
    }
    return(
    <div className="row">
        <div className="col-sm-4">
            <h3>Agregar Usuario</h3>
            <form className="form-group">
                <label className="form-label" for="nombre">Nombre</label>
                    <input className="form-control" type="text" id="nombre" name="nombre"
                        placeholder="Ingrese le nombre"
                        onChange={(e) => actualizarDato(e)} value={usuario.nombre}>
                </input>
                <label className="form-label" for="apellido">Apellido</label>
                <input className="form-control" type="text" id="apellido" name="apellido"
                        placeholder="Ingrese le apellido"
                        onChange={(e) => actualizarDato(e)} value={usuario.apellido}>
                </input>
                <label className="form-label" for="correo">Correo</label>
                <input className="form-control" type="text" id="correo" name="correo"
                        placeholder="Ingrese le correo"
                        onChange={(e) => actualizarDato(e)} value={usuario.correo}>
                </input>
                <label className="form-label" for="contra">Password</label>
                <input className="form-control" type="text" id="contra" name="contra"
                        placeholder="Ingrese la contrase&ntilde;a"
                        onChange={(e) => actualizarDato(e)} value={usuario.contra}>
                </input>
                <div className="d-grip gap-2 mt-2 mb-4">
                        <button className="btn btn-success" onClick={enviarDatos}>Agregar</button>
                </div>
            </form>
        </div>
        </div>
    )
}
export default Formulario
