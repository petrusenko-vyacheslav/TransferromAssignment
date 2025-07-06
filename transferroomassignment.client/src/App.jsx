import './App.css';
import { useState } from 'react';
import TeamSearch from './TeamSearch';
import Squad from './Squad';

function App() {
    const [team, setTeam] = useState('');
    const [players, setPlayers] = useState([]);
    const resetState = () => {
        setTeam('');
        setPlayers([]);
    }

    if (team) {
        return <Squad team={team} players={players} backToSearchhandler={resetState} />
    }
    return <TeamSearch setTeam={setTeam} setPlayers={setPlayers} />
}

export default App;