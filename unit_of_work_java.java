import org.hibernate.Session;
import org.hibernate.Transaction;

public class UnitOfWork implements AutoCloseable {
    private Session session;
    private Transaction transaction;

    public UnitOfWork(Session session) {
        this.session = session;
        this.transaction = session.beginTransaction();
    }

    public void commit() {
        transaction.commit();
    }

    public void rollback() {
        transaction.rollback();
    }

    public Session getSession() {
        return session;
    }

    @Override
    public void close() {
        session.close();
    }
}
