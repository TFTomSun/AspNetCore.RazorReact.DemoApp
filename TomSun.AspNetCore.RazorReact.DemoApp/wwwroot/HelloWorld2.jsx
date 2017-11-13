var HelloWorld = React.createClass({
    getInitialState() {
        dotnetify.react.connect("HelloWorld", this);
        return { Greetings: "", ServerTime: "" };
    },
    render() {
        return (
            <div>
                {this.state.Greetings}<br />
                Server time is: {this.state.ServerTime}
            </div>
        );
    }
});

ReactDOM.render(
    <HelloWorld />,
    document.getElementById('Content')
);