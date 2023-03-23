import '../styles/User.css'
import Formulario from "./Formulario";
import TablaContenido from './TablaContenido';
import { useEffect, useState } from 'react';
const User = () => {
    const [usuario, setUsuario] = useState([]);
    const mostrarUsuario = async () => {
        const response = await fetch('api/usuario/Lista');
        if (response.ok) {
            const data = await response.json();
            console.log(data);
            setUsuario(data);
        }
        else {
            console.log(`error de lista ${response.status}`)
        }
    }
    useEffect(() => {
        mostrarUsuario()
    }, [])

    const guardarDatos = async (usuario) => {
        const response = await fetch("api/usuario/Guardar", {
            method: "POST",
            headers: { 'Context-Type': 'application/json;charset=utf-8' },
            body: JSON.stringify(usuario)
        })
        if (response.ok) {
            mostrarUsuario();
        }
    }

    return (
        <div>
        <br/><br/><br/><br/>
            <Formulario guardarUsuario={guardarDatos} />
        <br/><br/><br/>
            <TablaContenido lista={usuario} />
        </div>
    )

}
export default User;