import React from 'react';

import logo from './logo.svg';
import './App.css';
import NewExpense from './components/NewExpense/NewExpense';

import RenderExpenses from './components/Expenses/RenderExpenses';

function App() {                     //this line can be an arrow function: const App = () => { which does the same
  const expenses = [
    {
      id: 'e1',
      title: 'Toilet Paper',
      amount: 94.12,
      date: new Date(2020, 7, 14),
    },
    { id: 'e2', title: 'New TV', amount: 799.49, date: new Date(2021, 2, 12) },
    {
      id: 'e3',
      title: 'Car Insurance',
      amount: 294.67,
      date: new Date(2021, 2, 28),
    },
    {
      id: 'e4',
      title: 'New Desk (Wooden)',
      amount: 450,
      date: new Date(2021, 5, 12),
    },
  ];

  return (
    <div>
      <NewExpense />
      <RenderExpenses expenses={expenses} />
    </div>

    // alternatively and an old-fashion way, you need import React from 'react'     
    // return React.createElement(                             createElement takes 3 or more arguments: element to be created, attributes of the created element, and the rest content b/w tags
    //   'div',
    //   {},
    //   React.createElement('h2', {}, "Let's get started"),
    //   React.createElement(Expenses, {items: expenses}, )
    // )

  );
}

export default App;
