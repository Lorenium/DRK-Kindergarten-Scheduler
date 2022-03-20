from flask import Flask, render_template, request
from flask_sqlalchemy import SQLAlchemy
from werkzeug.utils import redirect
from datetime import datetime

app = Flask(__name__)
# to see the css file changes without caching
app.config['SEND_FILE_MAX_AGE_DEFAULT'] = 0
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///test.db'
db = SQLAlchemy(app)

class Personnel(db.model):
    id = db.Column(db.Integer, primary_key=True)
    date_created = db.Column(db.DateTime, defualt = datetime.utcnow)

    def __repr__(self):
        return '<Personnel %r>' % self.id







