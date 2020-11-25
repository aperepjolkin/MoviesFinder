import React, {Component, useEffect} from 'react'
import Navigation from './Nav'
import SearchArea from './SearchArea'
import Movie from './Movie'
import Container from 'react-bootstrap/Container'
import Row  from 'react-bootstrap/Row'

class App extends Component {
	
	constructor() {
		super()

		this.state = {
			findMovieByTitle: '',
			movies: [],
			searchTerm: '',
			showResult: false
		}
		this.apiKey = process.env.REACT_APP_API
		
	}

	handleSubmit = (e) => {
		e.preventDefault();

		(async () => {
			const rawResponse = await fetch('https://localhost:44308/Movies', {
			  method: 'POST',
			  headers: {
				'Accept': 'application/json',
				'Content-Type': 'application/json'
			  },
			  body: JSON.stringify({"Title": this.state.searchTerm})
			})
			.then(data => data.json())
			.then(data => {
				console.log('data ' + data);
				this.setState({
					findMovieByTitle: JSON.parse(data)
					
					//findMovieByTitle: data.results	
				})
			});
			// const data = await rawResponse.json();
			// this.setState({
			// 	movies: data.results
			// })
			// console.log(movies);
			if(this.state.findMovieByTitle !== null){ 
				this.setState({
					showResult: true
	
				})
				console.log(this.state.showResult)
			}
			console.log(typeof this.state.findMovieByTitle);
			console.log('movie ' + this.state.findMovieByTitle);
		  })();


		
		// fetch(`http://www.omdbapi.com/?apikey=7878efa8&t=${this.state.searchTerm}`)
		// .then(data => data.json())
		// .then(data => {
		// 	console.log(data);
		// 	this.setState({
		// 		movies: data.results
		// 	})
		// })
	}

	showSearchedMoviesList = () => {
		(async () => {
			const rawResponse = await fetch('https://localhost:44308/Movies', {
			  method: 'GET',
			  headers: {
				'Accept': 'application/json',
				'Content-Type': 'application/json'
			  }
			})
			.then(data => data.json())
			.then(data => {
				console.log('data ' + data);
				this.setState({
					movies: [...JSON.parse(data)]
				})
			});

			console.log(typeof this.state.movies);
			console.log('movies list ' + this.state.movies);
		  })();
	}
	handleChange = (e) => {
		console.log(e.target.value)
		this.setState({ searchTerm: e.target.value })
	}
	render() {
		const { showResult } = this.state;
		return (
			<div className="App"> 
			<Container>
				<Navigation />
				<Row>
						<SearchArea handleSubmit={this.handleSubmit} handleChange={this.handleChange}/>
				</Row>
				{  showResult && (
					<Movie movie={this.state.findMovieByTitle} />
				)}
		    </Container>
			</div>
			);
		}
	}
  

export default App;
