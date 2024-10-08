{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    background-color: #f4f4f4;
    font-family: Arial, sans-serif;
}

.calculator {
    width: 300px;
    background-color: #fff;
    border-radius: 10px;
    box-shadow: 0px 5px 15px rgba(0, 0, 0, 0.2);
    overflow: hidden;
}

.display {
    width: 100%;
    height: 60px;
    background-color: #222;
    color: #fff;
    font-size: 2em;
    text-align: right;
    padding: 10px;
    border: none;
}

.buttons {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    gap: 10px;
    padding: 20px;
}

.btn {
    background-color: #f1f1f1;
    font-size: 1.5em;
    border: none;
    padding: 20px;
    border-radius: 5px;
    cursor: pointer;
    transition: background-color 0.2s ease;
}

.btn:hover {
    background-color: #ddd;
}

.operator {
    background-color: #ff9800;
    color: white;
}

.operator:hover {
    background-color: #e68900;
}

.equal {
    background-color: #4caf50;
    color: white;
    grid-column: span 2;
}

.equal:hover {
    background-color: #45a045;
}
