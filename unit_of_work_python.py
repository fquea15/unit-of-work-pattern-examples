from contextlib import contextmanager
from sqlalchemy.orm import sessionmaker

@contextmanager
def unit_of_work(Session):
    session = Session()
    try:
        yield session
        session.commit()
    except:
        session.rollback()
        raise
    finally:
        session.close()
