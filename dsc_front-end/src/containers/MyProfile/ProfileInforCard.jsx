import React from 'react';
import styles from './ProfileInforCard.module.css';

function ProfileInforCard({ title, value }) {
  return (
    <div className={styles.card}>
      <h3 className={styles.cardTitle}>{title}</h3>
      <div className={styles.cardContent}>
        <p className={styles.cardValue}>{value}</p>
        <button className={styles.editButton}>Chỉnh sửa</button>
      </div>
    </div>
  );
}

export default ProfileInforCard;