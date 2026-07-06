const url = 'http://localhost:5157/api/values/add/5/20';
console.log(`Request to: ${url} ...`);

async function sendData() {
    await fetch(url, { method: 'GET'})
    .then(response => {
        if (!response.ok) {
            throw new Error(`Server Error WebApi: ${response.status} ${response.statusText}`);
        }
        return response.json();
    })
    .then(data => {
        console.log('\n---Recived Data---');
        console.log(JSON.stringify(data, null, 2));
    })
    .catch(error => {
        console.error('\nConnection Error: ', error.message);
    })
}

sendData();