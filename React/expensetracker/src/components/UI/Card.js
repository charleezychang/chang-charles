import React from 'react';

import './Card.css'
//making a wrapper component
function Card (props) {
    const classes = 'card ' + props.className;
    //adding a built-in attribute for div: className, as a part of the custom attributes
    return <div className={classes}>{props.children}</div>
    // props.children is a special unique prop which takess content between the opening and closing custom tag as a prop
}


export default Card;