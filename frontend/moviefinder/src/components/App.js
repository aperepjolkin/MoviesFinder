import React, {Component} from 'react'
import Navigation from './Nav'
import SearchArea from './SearchArea'
import Movie from './Movie'

class App extends Component {
	
	constructor() {
		super()

		this.state = {
			findMovieByTitle: '',
			movies: [],
			searchTerm: ''
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
				console.log(data);
				this.setState({
					findMovieByTitle: data.results
				})
			});
			// const data = await rawResponse.json();
			// this.setState({
			// 	movies: data.results
			// })
			// console.log(movies);
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

	handleChange = (e) => {
		console.log(e.target.value)
		this.setState({ searchTerm: e.target.value })
	}
	render() {
		return (
			<div className="App"> 
				<Navigation />
				<SearchArea handleSubmit={this.handleSubmit} handleChange={this.handleChange}/>
				<Movie movie={this.state.findMovieByTitle} />
				
			</div>
			);
		}
	}
  

export default App;
