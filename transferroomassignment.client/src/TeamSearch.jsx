import './App.css';
import { useState } from 'react';

function TeamSearch({setTeam, setPlayers}) {
    const [teamToLookFor, setTeamToLookFor] = useState('');
    const [error, setError] = useState('');

    const squadSearchInputOnChange = (e) => setTeamToLookFor(e.target.value);

    const getSquad = async () => {
        const response = await fetch(`api/squads/get?team=${teamToLookFor}`);
        if (response.ok) {
            const data = await response.json();
            setTeam(data.team);
            setPlayers(data.players)
            setError('');
        } else {
            const error = await response.text();
            setError(error);
        }
    }
    const renderError = error ? <div className="alert alert-danger" role="alert">
                                    {error}
                                </div>
                              : null;
    return (
        <div className='searchContainer'>
            <div className="formContainer">
                <form action={getSquad}>
                    <div className="mb-3">
                        <label htmlFor="squadSearchInput" className="form-label">Team</label>
                        <input type="text" className="form-control" id="squadSearchInput" onChange={squadSearchInputOnChange} required />
                        <div id="emailHelp" className="form-text">You can search by team name i.e 'Liverpool' or team nickname i.e 'The Reds'.</div>
                    </div>
                    <button type="submit" className="btn btn-primary">Submit</button>
                </form>
            </div>
            { renderError }
        </div>
    );
}

export default TeamSearch;