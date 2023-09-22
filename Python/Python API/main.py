from django.core.wsgi import Django

app = Django(__name__)

@app.route("/")
def home():
    return "Home"

if __name__ == "__main__":
    app.run(debug=True)