function Squad({team, players, backToSearchhandler}) {
    const rows = players.map(p => <tr key={p.name}><td><img src={p.profilePictureUrl}></img></td><td>{p.name}</td><td>{p.age}</td><td>{p.position}</td></tr>)
    return (
        <div className="squadContainer">
            <button type="button" className="btn btn-primary" onClick={backToSearchhandler}>Back to search</button>
            <h1 className="squadHeader">{team}</h1>
            <table className="table table-bordered">
                <thead>
                    <tr>
                        <th scope="col">Photo</th>
                        <th scope="col">Name</th>
                        <th scope="col">Age</th>
                        <th scope="col">Position</th>
                    </tr>
                </thead>
                <tbody>
                    {rows}
                </tbody>
            </table>
        </div>
    )
}

export default Squad;