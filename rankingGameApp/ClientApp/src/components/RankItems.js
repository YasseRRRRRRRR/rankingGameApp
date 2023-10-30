import React, { useState, useEffect } from 'react';
import GameImageArr from './GameImages';

const RankItems = () => {

    const [items, setItems] = useState([]);
    const dataType = 1;

    useEffect(() => {
        fetch(`item/${dataType}`)
            .then((result) => {
                return result.json();
            })
            .then((data) => {
                setItems(data);
            }) 
    }, []);



    return (
        <main>
            <div className = "items-not-ranked">
            {
                    (items.length > 0) ? items.map((item) =>
                    <div className = "unranked-cell">
                    <img id={`item-${item.id}`} src={GameImageArr.find(o => o.id === item.imageId)?.image } />
                    </div>
                    ) : <div>Loading...</div>
                    
            }
            </div>
        </main>
    )
}
export default RankItems;