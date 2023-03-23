const TablaContenido = ({lista }) => {
    return (
        <div className="row">
            <div className="col-sm-12">
                <h5 className="d-flex justify-content-center">Lista de usuarios</h5>
                <hr />
                <table className="table table-striped-columns">
                    <thead>
                        <tr>
                            
                            <th>Nombre</th>
                            <th>Apellido</th>
                            <th>Correo</th>
                            <th>Password</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>{
                        (lista.length < 1) ? (
                            <tr>
                                <td className="4">No existen usuarios</td>
                            </tr>) : (
                            lista.map((item) => (
                                <tr key={item.idUsuario}>
                                    
                                    <th>{item.nombre}</th>
                                    <th>{item.apellido}</th>
                                    <th>{item.correo}</th>
                                    <th>{item.contra}</th>
                                </tr>)
                            ))

                    }
}
                     </tbody>
                </table>
            </div>
        </div>
    )
}
export default TablaContenido;
